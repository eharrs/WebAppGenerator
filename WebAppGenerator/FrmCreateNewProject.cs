using System;
using System.Windows.Forms;

namespace WebAppGenerator
{
    public partial class FrmCreateNewProject : Form
    {
        private string _sProjectTypeFolder = "";

        public FrmCreateNewProject()
        {
            InitializeComponent();
            cboProjectType.Text = "C# Web Application";
            txtProjectLocation.Text = @"C:\Users\Eric\Documents\Visual Studio 2015\Projects";
        }

        #region ----- Event Handlers -----

        private void btnProjectLocation_Click( object sender, EventArgs e )
        {
            if ( folderBrowserDialog1.ShowDialog() == DialogResult.OK )
            {
                txtProjectLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCreateProject_Click( object sender, EventArgs e )
        {
            MessageBox.Show( "Transfering Project" );
        }

        private void cboProjectType_TextChanged( object sender, EventArgs e )
        {
            switch ( cboProjectType.Text )
            {
                case "C# Web Application":
                    _sProjectTypeFolder = "CSharpWebApp";
                    break;
            }
                        
            EnableTransferButton();
        }

        private void txtProjectName_TextChanged( object sender, EventArgs e )
        {
            EnableTransferButton();
        }

        private void txtSolutionName_TextChanged( object sender, EventArgs e )
        {
            EnableTransferButton();
        }

        private void txtProjectLocation_TextChanged( object sender, EventArgs e )
        {
            EnableTransferButton();
        }

        private void EnableTransferButton()
        {
            // If any of the required fields are not filled in, disable the submit button.
            if (
                string.IsNullOrWhiteSpace( cboProjectType.Text ) ||
                string.IsNullOrWhiteSpace( txtProjectName.Text ) ||
                string.IsNullOrWhiteSpace( txtSolutionName.Text ) ||
                string.IsNullOrWhiteSpace( txtProjectLocation.Text )
                )
            {
                btnCreateProject.Enabled = false;
            }
            else
            {
                btnCreateProject.Enabled = true;
            }

        }

        private void txtProjectName_Leave( object sender, EventArgs e )
        {
            // If the user has entered a project name, and the solution name is blank, then make the solution name the same.
            if ( !string.IsNullOrWhiteSpace( txtProjectName.Text ) && string.IsNullOrWhiteSpace( txtSolutionName.Text ) )
            {
                txtSolutionName.Text = txtProjectName.Text;
            }
        }

        #endregion ----- Event Handlers -----

    }
}
