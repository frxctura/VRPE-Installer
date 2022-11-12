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
using Telerik.WinControls;
using System.IO;

namespace VRPE_Installer
{
    public class Buttons
    {
    public static void FirewallException()
        {
            var path = ("C:/Program Files (x86)/VRP/Rookie/AndroidSideloader");
            var ver = "2.16";
            Console.WriteLine(path+ver);
            System.Diagnostics.Process.Start($"netsh firewall add allowedprogram {path}+{ver}.exe ROOKIE-SIDELOADER ENABLE");
        }
    }
}
