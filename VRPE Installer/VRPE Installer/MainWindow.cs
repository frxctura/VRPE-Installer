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
using Telerik.WinControls.UI;

namespace VRPE_Installer
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        public Form1()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
        }

        private void minimizeButton_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
            Close();
        }

        private void onMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            welcomeLabel.Hide();
            backButton.Show();
            rookieButton.Show();
            vrpguiButton.Show();
            resilioButton.Show();  
            firewallCheckbox.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            backButton.Hide();
            welcomeLabel.Show();
            rookieButton.Hide();
            vrpguiButton.Hide();
            resilioButton.Hide();
            firewallCheckbox.Hide();
        }

        private void rookieButton_Click(object sender, EventArgs e)
        {
            if (firewallCheckbox.Checked)
            {
               Buttons.FirewallException();
            }
        }
    }
}
