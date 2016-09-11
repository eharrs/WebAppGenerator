using System;
using System.Windows.Forms;

namespace WebAppGenerator
{
    public partial class frmWebAppGenerator : Form
    {
        private readonly Settings _settings;

        public frmWebAppGenerator( Settings settings )
        {
            _settings = settings;
            InitializeComponent();
        }

        #region ----- Menu Event Handlers -----

        private void fileExitMenuItem_Click( object sender, EventArgs e )
        {
            Application.Exit();
        }

        private void projectNewMenuItem_Click( object sender, EventArgs e )
        {
            FrmCreateNewProject frmCreateNewProject = new FrmCreateNewProject( _settings );
            frmCreateNewProject.Show();
        }

        #endregion ----- Menu Event Handlers -----
    }
}
