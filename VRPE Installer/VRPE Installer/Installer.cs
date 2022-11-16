using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static VRPE_Installer.Downloader;
using System.Diagnostics;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Runtime.ExceptionServices;

namespace VRPE_Installer
{
    internal class Installer
    {
        public static async Task InstallRookie()
        {
            var destinationFilePath = Path.GetFullPath($"{MainWindow.selectedPath}{MainWindow.fixPath}RSL.zip");
            var storePath = Path.GetFullPath($"{MainWindow.selectedPath}{MainWindow.fixPath}");
            var outputFolder = Path.GetFullPath($"{MainWindow.selectedPath}{MainWindow.fixPath}");
            try
            {
                ZipFile.ExtractToDirectory(destinationFilePath, outputFolder);
                File.Delete(destinationFilePath);
            }
            catch (Exception ex) {
                 string message =
                    $"{ex.Message}";
                string caption = "Error while Unzipping!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task InstallVRPGUI(string password = null)
        {
            var destinationFilePathVRPGUI = Path.GetFullPath($"{MainWindow.selectedPathVRPGUI}{MainWindow.fixPath}VRPGUI.zip");
            var outputFolder = Path.GetFullPath($"{MainWindow.selectedPathVRPGUI}{MainWindow.fixPath}");
            var createFolderPathVRPGUI = Path.GetFullPath($"{MainWindow.selectedPathVRPGUI}{MainWindow.fixPath}VRP-GUI");
            try
            {
                Directory.CreateDirectory($"{createFolderPathVRPGUI}");
                ZipFile.ExtractToDirectory(destinationFilePathVRPGUI, createFolderPathVRPGUI);
                File.Delete(destinationFilePathVRPGUI);
            }
            catch (Exception ex)
            {
                string message =
                   $"{ex.Message}";
                string caption = "Error while Unzipping!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}