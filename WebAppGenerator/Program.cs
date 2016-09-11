using System;
using System.Windows.Forms;

namespace WebAppGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Make sure the Settings.xml file is in the same directory as this app's executable.
            Settings settings = new Settings();
            settings.LoadSettings( "Settings.xml" );

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new frmWebAppGenerator( settings ) );
        }
    }
}
