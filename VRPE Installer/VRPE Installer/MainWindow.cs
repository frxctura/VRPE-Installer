using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VRPE_Installer
{
    public partial class MainWindow : Form
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
        public static string selectedPath;
        public static string selectedPathVRPGUI;
        public static string selectedPathResilio;
        public static string fixPath;
        public MainWindow()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            System.IO.Directory.CreateDirectory(@"C:\VRPE\");
            FileStream fs = File.Create(@"C:\VRPE\LoggedInstallPaths.txt");
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

        private void nextButton_Click(object sender, EventArgs e)
        {
            wikiLink.Hide();
            welcomeLabel.Hide();
            backButton.Show();
            nextButton.Hide();
            rookieButton.Show();
            vrpguiButton.Show();
            resilioButton.Show();
            firewallCheckbox.Show();
            resilioPathCheckbox.Show();
            downloadProgress.Show();
            if (File.Exists(@"C:/VRPE/RookiePath.txt"))
            {
                Buttons.rookiePath = File.ReadLines(@"C:/VRPE/RookiePath.txt").First();
                rookiePathLabel.Text = Buttons.rookiePath;
                LaunchRookie.Show();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            wikiLink.Show();
            backButton.Hide();
            nextButton.Show();
            welcomeLabel.Show();
            rookieButton.Hide();
            vrpguiButton.Hide();
            resilioButton.Hide();
            firewallCheckbox.Hide();
            resilioPathCheckbox.Hide();
            downloadProgress.Hide();
            if (File.Exists(@"C:/VRPE/RookiePath.txt"))
            {
                rookiePathLabel.Text = "";
                LaunchRookie.Hide();
            }
        }

        public async void rookieButton_Click(object sender, EventArgs e)
        {
            if (rookieFolderDialog.ShowDialog() == DialogResult.OK)
            {
                fixPath = @"\";
                selectedPath = rookieFolderDialog.SelectedPath;
                if (firewallCheckbox.Checked)
                {
                    downloadProgress.Show();
                    downloadProgress.Invoke((Action)(() => { downloadProgress.Style = ProgressBarStyle.Marquee; }));
                    topLabel.Text = "Downloading Rookie...";
                    topLabel.Refresh();
                    await Downloader.GetRookie();
                    topLabel.Text = "Extracting Rookie...";
                    topLabel.Refresh();
                    await Installer.InstallRookie();
                    topLabel.Text = "VRPE Installer";
                    Buttons.FirewallException();
                    string message = "Done!";
                    string caption = "Downloading & Extracting Finished";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    downloadProgress.Hide();
                }
                else
                {
                    downloadProgress.Show();
                    downloadProgress.Invoke((Action)(() => { downloadProgress.Style = ProgressBarStyle.Marquee; }));
                    topLabel.Text = "Downloading Rookie...";
                    topLabel.Refresh();
                    await Downloader.GetRookie();
                    topLabel.Text = "Extracting Rookie...";
                    topLabel.Refresh();
                    await Installer.InstallRookie();
                    topLabel.Text = "VRPE Installer";
                    topLabel.Refresh();
                    string message = "Done!";
                    string caption = "Downloading & Extracting Finished";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    downloadProgress.Hide();
                }
            }
        }

        private async void vrpguiButton_Click(object sender, EventArgs e)
        {
            if (vrpGUIFolderDialog.ShowDialog() == DialogResult.OK)
            {
                fixPath = @"\";
                selectedPathVRPGUI = vrpGUIFolderDialog.SelectedPath;
                downloadProgress.Show();
                topLabel.Text = "Downloading VRP GUI...";
                topLabel.Refresh();
                downloadProgress.Invoke((Action)(() => { downloadProgress.Style = ProgressBarStyle.Marquee; }));
                await Downloader.GetVRPGUI();
                topLabel.Text = "Extracting VRP GUI...";
                topLabel.Refresh();
                await Installer.InstallVRPGUI();
                topLabel.Text = "VRPE Installer";
                topLabel.Refresh();
                string message = "Done!";
                string caption = "Downloading & Extracting Finished";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                downloadProgress.Hide();
            }
        }

        private async void resilioButton_Click(object sender, EventArgs e)
        {
            if (resilioPathCheckbox.Checked)
            {
                if (resilioFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    fixPath = @"\";
                    selectedPathResilio = resilioFolderDialog.SelectedPath;
                    downloadProgress.Show();
                    topLabel.Text = "Downloading Resilio...";
                    topLabel.Refresh();
                    downloadProgress.Invoke((Action)(() => { downloadProgress.Style = ProgressBarStyle.Marquee; }));
                    await Downloader.GetResilio();
                    topLabel.Text = "VRPE Installer";
                    topLabel.Refresh();
                    string message = "Done!";
                    string caption = "Downloading & Extracting Finished";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    downloadProgress.Hide();
                }
            }
            else
            {
                    fixPath = @"\";
                    selectedPathResilio = System.IO.Path.GetTempPath();
                    downloadProgress.Show();
                    topLabel.Text = "Downloading Resilio...";
                    topLabel.Refresh();
                    downloadProgress.Invoke((Action)(() => { downloadProgress.Style = ProgressBarStyle.Marquee; }));
                    await Downloader.GetResilio();
                    topLabel.Text = "VRPE Installer";
                    topLabel.Refresh();
                    string message = "Done!";
                    string caption = "Downloading & Extracting Finished";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    downloadProgress.Hide();
                }
            }

        private void wikiLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://wiki.vrpirates.club/");
        }

        private void LaunchRookie_Click(object sender, EventArgs e)
        {
            Buttons.LaunchRookie();
        }
    }
    }
