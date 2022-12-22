using System;
using System.Windows.Forms;

namespace VRPE_Installer
{
    internal class MessageBoxes
    {
        public static string exceptionMessage;
        public static string innerExceptionMessage;

        // Show the user that the process has finished.
        public static void Finish()
        {
            MessageBox.Show("Downloading & Extracting Finished", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Show the user what Error caused the Download/Install to fail.
        public static void DownloadError(string exceptionMessage, string innerExceptionMessage)
        {
            MessageBox.Show(exceptionMessage + Environment.NewLine + innerExceptionMessage, "Error while Downloading!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void InstallError(string exceptionMessage, string innerExceptionMessage)
        {
            MessageBox.Show($"{exceptionMessage}\n{innerExceptionMessage}", "Error while Unzipping/Installing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
