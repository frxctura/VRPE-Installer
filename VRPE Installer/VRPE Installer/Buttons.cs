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
            Console.WriteLine($"{path}{fixPath}{folderName}{fixPath}AndroidSideloader_v{ver}.exe");
            ProcessStartInfo info = new ProcessStartInfo("netsh.exe");
            info.Arguments = $"advfirewall firewall add allowedprogram {finishedPath}ROOKIE-SIDELOADER ENABLE";
            System.Diagnostics.Process.Start(info);
        }
    }
}
