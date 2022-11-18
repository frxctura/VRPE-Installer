using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Diagnostics;

namespace VRPE_Installer
{
    public class Buttons
    {
        public static string ver = string.Empty;
        public static void FirewallException()
        {
            HttpClient client = new HttpClient();
            var fixPath = MainWindow.fixPath;
            var path = MainWindow.selectedPath;
            string ver = client.GetStringAsync("https://raw.githubusercontent.com/nerdunit/androidsideloader/master/version").Result;
            var folderName = $"rookie_{ver}_portable";
            string finishedPath = $"{path}{fixPath}{folderName}{fixPath}AndroidSideloader_v{ver}.exe";
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "CMD.EXE";
            info.Arguments = $"/K netsh.exe firewall add allowedprogram {finishedPath} ROOKIE-SIDELOADER ENABLE";
            p.StartInfo = info;
            p.Start();
            p.WaitForExit();
        }
        public static void LaunchRookie()
        {
            HttpClient client = new HttpClient();
            string ver = client.GetStringAsync("https://raw.githubusercontent.com/nerdunit/androidsideloader/master/version").Result;
            string rookiePath = File.ReadLines(@"C:/VRPE/RookiePath.txt").First();
            Console.WriteLine(rookiePath);
            try
            {
                Process.Start(rookiePath);
            }
            catch (Exception ex)
            {
                string message = $"{ex.Message}";
                string caption = "Error when trying to launch Rookie!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
