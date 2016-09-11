using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebAppGenerator
{
    public partial class frmWebAppGenerator : Form
    {
        public frmWebAppGenerator()
        {
            InitializeComponent();
        }

        #region ----- Menu Event Handlers -----

        private void fileExitMenuItem_Click( object sender, EventArgs e )
        {
            Application.Exit();
        }

        private void projectNewMenuItem_Click( object sender, EventArgs e )
        {
            FrmCreateNewProject frmCreateNewProject = new FrmCreateNewProject();
            frmCreateNewProject.Show();
        }

        #endregion ----- Menu Event Handlers -----
    }
}
