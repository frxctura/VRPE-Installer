using System.Windows.Forms;

namespace VRPE_Installer
{
    internal class MessageBoxes
    {
        public static string exceptionMessage;

        // Show the user that the process has finished.
        public static void Finish()
        {
            MessageBox.Show("Downloading & Extracting Finished", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Show the user what Error caused the Download to fail.
        public static void DownloadError()
        {
            MessageBox.Show(exceptionMessage, "Error while Downloading!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void InstallError()
        {
            MessageBox.Show(exceptionMessage, "Error while Unzipping/Installing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
