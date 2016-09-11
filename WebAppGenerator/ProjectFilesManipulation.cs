using System.IO;
using System.Windows.Forms;

namespace WebAppGenerator
{
    public class ProjectFilesManipulation
    {
        private readonly Settings _settings;

        public ProjectFilesManipulation( Settings settings )
        {
            _settings = settings;
        }

        public void CopyProjectToNewLocation( string copyFromLocation, string copyToLocation )
        {
            // The shell script requires the path be enclosed in quotation marks to account for spaces in the path.
            string formattedFromFullPathFile = "\"" + copyFromLocation + "\"";
            string formattedToFullPathFile = "\"" + copyToLocation + "\"";

            // Check if the project already exists at the given location.
            if ( Directory.Exists( copyToLocation ) )
            {
                string msg = "A project already exists at " + copyToLocation + ".\n\nDo you want to replace it?";
                DialogResult dialogResult = MessageBox.Show( msg, "Overwrite Project", MessageBoxButtons.YesNo );
                if ( dialogResult == DialogResult.Yes )
                {
                    // Remove the directory and continue the copy process.
                    Directory.Delete( copyToLocation, true );
                }
                else
                {
                    return;
                }
            }

            ShellScriptRunner shellScriptRunner = new ShellScriptRunner( _settings );
            shellScriptRunner.CopyProjectToNewLocation( formattedFromFullPathFile, formattedToFullPathFile );

            MessageBox.Show( "A new project was successfully create at: " + copyToLocation, "Create Project" );
        }

    }
}
