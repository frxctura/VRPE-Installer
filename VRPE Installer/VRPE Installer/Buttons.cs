using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VRPE_Installer
{
    public class Buttons
    {
        // Adds a firewall exception to the Rookie exe when the user prompted VRPE to do so with the checkmark, unsure if works or not.
        public static void FirewallException(string selectedPath, string fixPath, string ver)
        {
            var folderName = $"rookie_{ver}_portable";
            var targetFolder = Path.Combine(selectedPath, folderName);
            var finishedPath = Path.Combine(targetFolder, $"AndroidSideloader_v{ver}.exe");
            Console.WriteLine(finishedPath);
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "CMD.EXE";
            info.Arguments = $"/K netsh.exe firewall add allowedprogram {finishedPath} ROOKIE-SIDELOADER ENABLE";
            p.StartInfo = info;
            p.Start();
            p.WaitForExit();
        }

        // As the method name suggests, this launches rookie, lol.
        public static void LaunchRookie(string ver)
        {
            var rookiePath = File.ReadLines(@"C:/RSL/RookiePath.txt").First();
            Console.WriteLine(rookiePath);
            try
            {
                ProcessStartInfo p = new ProcessStartInfo();
                p.WorkingDirectory = rookiePath;
                p.FileName = $"AndroidSideloader_v{ver}.exe";
                p.CreateNoWindow = true;
                Process startRookie = Process.Start(p);
            }
            catch (Exception ex)
            {
                string message = $"{ex.Message}";
                string caption = "Error when trying to launch Rookie!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Opens the Path in which Rookie was last installed in.
        public static void rookiePathOpener()
        {
            var rookiePath = File.ReadLines(@"C:/RSL/RookiePath.txt").First();
            ProcessStartInfo p = new ProcessStartInfo
            {
                Arguments = rookiePath,
                FileName = "explorer.exe"
            };
            Process.Start(p);
        }
    }
}
