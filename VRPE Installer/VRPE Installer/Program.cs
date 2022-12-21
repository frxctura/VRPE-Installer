using System;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;
using JR.Utils.GUI.Forms;

namespace VRPE_Installer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static HttpClient HttpClient;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            HttpClient = new HttpClient();
            Application.Run(new MainWindow());
        }
    }
}
