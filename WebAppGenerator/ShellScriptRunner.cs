using System;
using System.Diagnostics;
using System.IO;

namespace WebAppGenerator
{
    public class ShellScriptRunner
    {
        private readonly Settings _settings;

        public ShellScriptRunner( Settings settings )
        {
            _settings = settings;
        }

        public void CopyProjectToNewLocation( string copyFromLocation, string copyToLocation )
        {
            string utilitiesPath = _settings.GetSettingValue( "UtilitiesPath" );
            string shellScriptToCopyProject = _settings.GetSettingValue( "BatchFileToCopyProject" );

            string shellScriptToRun = Path.Combine( utilitiesPath, shellScriptToCopyProject );
            string arguments = $"{copyFromLocation} {copyToLocation}";
            RunShellScript( shellScriptToRun, arguments );
        }

        private void RunShellScript( string shellScriptToRun, string arguments )
        {
            ProcessStartInfo startInfo = new ProcessStartInfo( shellScriptToRun );
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = arguments;

            try
            {
                using ( Process exeProcess = Process.Start( startInfo ) )
                {
                    exeProcess.WaitForExit();
                }
            }
            catch( Exception ex )
            {
                Console.WriteLine( ex.Message );
                // Log error.
            }
        }
    }
}
