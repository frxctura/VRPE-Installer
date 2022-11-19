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
using System.Runtime.ConstrainedExecution;
using System.Net.Http;

namespace VRPE_Installer
{
    internal class Installer
    {
        public static async Task InstallRookie()
        {
            HttpClient client = new HttpClient();
            var destinationFilePath = Path.GetFullPath($"{MainWindow.selectedPath}{MainWindow.fixPath}RSL.zip");
            var storePath = Path.GetFullPath($"{MainWindow.selectedPath}{MainWindow.fixPath}");
            var outputFolder = Path.GetFullPath($"{MainWindow.selectedPath}{MainWindow.fixPath}");
            string ver = client.GetStringAsync("https://raw.githubusercontent.com/nerdunit/androidsideloader/master/version").Result;
            var folderName = $"rookie_{ver}_portable";
            var VRPEPATH = @"C:\VRPE\";
            try
            {
                if (!Directory.Exists(VRPEPATH))
                {
                    Directory.CreateDirectory(@"C:/VRPE");
                    using (StreamWriter sw = File.CreateText($"{VRPEPATH}/RookiePath.txt"))
                    {
                        sw.WriteLine($"{storePath}{folderName}{MainWindow.fixPath}AndroidSideloader_v{ver}.exe");
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText($"{VRPEPATH}/RookiePath.txt"))
                    {
                        sw.WriteLine($"{storePath}{folderName}{MainWindow.fixPath}AndroidSideloader_v{ver}.exe");
                    }
                }
                ZipFile.ExtractToDirectory(destinationFilePath, outputFolder);
                File.Delete(destinationFilePath);
            }
            catch (Exception ex) {
                string message = $"{ex.Message}";
                string caption = "Error while Unzipping/Installing!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task InstallVRPGUI(string password = null)
        {
            var destinationFilePathVRPGUI = Path.GetFullPath($"{MainWindow.selectedPathVRPGUI}{MainWindow.fixPath}VRPGUI.zip");
            var outputFolder = Path.GetFullPath($"{MainWindow.selectedPathVRPGUI}{MainWindow.fixPath}");
            var createFolderPathVRPGUI = Path.GetFullPath($"{MainWindow.selectedPathVRPGUI}{MainWindow.fixPath}VRP-GUI");
            var VRPEPATH = @"C:\VRPE\";
            try
            {
                if (!Directory.Exists(VRPEPATH))
                {
                    Directory.CreateDirectory(@"C:/VRPE");
                    using (StreamWriter sw = File.CreateText($"{VRPEPATH}/VRPGUIPath.txt"))
                    {
                        sw.WriteLine(createFolderPathVRPGUI);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText($"{VRPEPATH}/VRPGUIPath.txt"))
                    {
                        sw.WriteLine(createFolderPathVRPGUI);
                    }
                }
                Directory.CreateDirectory($"{createFolderPathVRPGUI}");
                ZipFile.ExtractToDirectory(destinationFilePathVRPGUI, createFolderPathVRPGUI);
                File.Delete(destinationFilePathVRPGUI);
            }
            catch (Exception ex)
            {
                string message = $"{ex.Message}";
                string caption = "Error while Unzipping/Installing!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}