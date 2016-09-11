using System;
using System.IO;
using System.Windows.Forms;

namespace WebAppGenerator
{
    public partial class FrmCreateNewProject : Form
    {
        private readonly Settings _settings;
        private string _sProjectTypeFolder = "";

        public FrmCreateNewProject( Settings settings )
        {
            _settings = settings;

            InitializeComponent();

            cboProjectType.Text = _settings.GetSettingValue( "DefaultProjectTypeToGenerate" );
            txtProjectLocation.Text = _settings.GetSettingValue( "DefaultPathToGenerateProjectTo" );
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
            string projectTemplatePath = _settings.GetSettingValue( "ProjectTemplatePath" );
            string solutionNamePlaceholder = _settings.GetSettingValue( "SolutionNamePlaceholder" );

            string fromDirectory = Path.Combine( projectTemplatePath, _sProjectTypeFolder );
            string fromFullPathFile = Path.Combine( fromDirectory, solutionNamePlaceholder );
            string toFullPathFile = Path.Combine( txtProjectLocation.Text, txtSolutionName.Text );

            ProjectFilesManipulation projectFilesManipulation = new ProjectFilesManipulation( _settings );
            projectFilesManipulation.CopyProjectToNewLocation( fromFullPathFile, toFullPathFile );
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

        private void txtProjectName_Leave( object sender, EventArgs e )
        {
            // If the user has entered a project name, and the solution name is blank, then make the solution name the same.
            if ( !string.IsNullOrWhiteSpace( txtProjectName.Text ) && string.IsNullOrWhiteSpace( txtSolutionName.Text ) )
            {
                txtSolutionName.Text = txtProjectName.Text;
            }
        }

        #endregion ----- Event Handlers -----

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

    }
}
