using System;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace VRPE_Installer
{
    internal class Installer
    {
        public static async Task InstallRookie()
        {
            var destinationFilePath = Path.GetFullPath($"{MainWindow.selectedPath}{MainWindow.fixPath}RSL.zip");
            var outputFolder = Path.GetFullPath($"{MainWindow.selectedPath}{MainWindow.fixPath}");
            try
            {   
                // Log the path in which Rookie was last installed in.
                PathLogger.LogRookie();
                // Extract the RSL.zip into the selected path.
                ZipFile.ExtractToDirectory(destinationFilePath, outputFolder);
                // Delete the RSL.zip file as it is no longer needed.
                File.Delete(destinationFilePath);
            }
            catch (Exception ex) {
                // Catch and show the user any exception that happens during the entire process
                string message = $"{ex.Message}";
                string caption = "Error while Unzipping/Installing!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public static async Task InstallShortcutMaker()
        {
            var destinationFilePath = Path.GetFullPath($"{MainWindow.selectedPathShortcutMaker}{MainWindow.fixPath}ShortcutMaker.zip");
            var outputFolder = Path.GetFullPath($"{MainWindow.selectedPathShortcutMaker}{MainWindow.fixPath}");
            try
            {
                // Extract the ShortcutMaker.zip into the selected path.
                ZipFile.ExtractToDirectory(destinationFilePath, outputFolder);
                // Delete the ShortcutMaker.zip file as it is no longer needed.
                File.Delete(destinationFilePath);
            }
            catch (Exception ex)
            {
                // Catch and show the user any exception that happens during the entire process
                string message = $"{ex.Message}";
                string caption = "Error while Unzipping/Installing!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task InstallVRPGUI()
        {
            var destinationFilePathVRPGUI = Path.GetFullPath($"{MainWindow.selectedPathVRPGUI}{MainWindow.fixPath}VRPGUI.zip");
            var createFolderPathVRPGUI = Path.GetFullPath($"{MainWindow.selectedPathVRPGUI}{MainWindow.fixPath}VRP-GUI");
            try
            {
                // Log the Path in which VRPGUI was last installed in.
                PathLogger.LogVRPGUI();
                // Create a VRP-GUI folder otherwise all the files would just be extracted into the selected folder.
                Directory.CreateDirectory($"{createFolderPathVRPGUI}");
                // Extract VRPGUI into the created VRP-GUI folder from above which is inside the selected path.
                ZipFile.ExtractToDirectory(destinationFilePathVRPGUI, createFolderPathVRPGUI);
                // Lastly delete the VRPGUI.zip
                File.Delete(destinationFilePathVRPGUI);
            }
            catch (Exception ex)
            {
                // Catch and show the user any exception that happens during the entire process
                string message = $"{ex.Message}";
                string caption = "Error while Unzipping/Installing!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}