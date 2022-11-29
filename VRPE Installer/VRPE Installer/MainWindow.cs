using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VRPE_Installer
{
    public partial class MainWindow : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")] public static extern bool ReleaseCapture(); [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private Random rnd = new Random();
        public static string selectedPath;
        public static string selectedPathVRPGUI;
        public static string selectedPathResilio;
        public static string selectedPathShortcutMaker;
        public static string fixPath = @"\";
        public static string ver;
        public string normalTitle = "VRPE Installer";
        public string captionFinish = "Done!";
        public string messageFinish = "Downloading & Extracting Finished";
        public static bool RSLPathExists;
        public static bool RookiePathExists;
        public static bool VRPGUIPathExists;
        public static bool runningProcess;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect,int nTopRect,int nRightRect,int nBottomRect,int nWidthEllipse,int nHeightEllipse);
        // On Program start, set the RSL Path, create an HTTP Client to fetch the version number of Rookie and set the string, set bools true if files exist.
        public MainWindow()
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 891, 502, 25, 25));
            var RSLPATH = @"C:\RSL\";
            HttpClient client = new HttpClient();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            rainbowBorder.Start();
            ver = client.GetStringAsync("https://raw.githubusercontent.com/nerdunit/androidsideloader/master/version").Result;
            if (Directory.Exists(RSLPATH))
            {
                RSLPathExists = true;
            }
            if (File.Exists(@"C:/RSL/RookiePath.txt"))
            {
                RookiePathExists = true;
            }
            if (File.Exists(@"C:/RSL/VRPGUIPath.txt"))
            {
                VRPGUIPathExists = true;
            }
        }
        // Minimizes the program
        private void minimizeButton_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        // Closes the program
        private void closeButton_Click(object sender, System.EventArgs e)
        {
            if (!runningProcess)
            {
                Application.Exit();
                Close();
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to exit?\nThis will cancel any ongoing operation", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Application.Exit();
                    Close();
                }
            }
        }
        // Is needed to make the custom tab bar moveable
        private void onMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        // Goes to the main part of the installer with all the download buttons etc
        private void nextButton_Click(object sender, EventArgs e)
        {
            wikiLink.Hide();welcomeLabel.Hide();backButton.Show();nextButton.Hide();rookieButton.Show();vrpguiButton.Show();resilioButton.Show();firewallCheckbox.Show();resilioPathCheckbox.Show();shortcutmakerButton.Show();
            if (RookiePathExists)
            {
                rookiePathLabel.Text = File.ReadLines(@"C:/RSL/RookiePath.txt").First();
                rookiePathLabel.Refresh();
                LaunchRookie.Show();
                rookiePathOpen.Show();
            }
        }
        // Just goes back to the welcoming screen on the form
        private void backButton_Click(object sender, EventArgs e)
        {
            wikiLink.Show();backButton.Hide();nextButton.Show();welcomeLabel.Show();rookieButton.Hide();vrpguiButton.Hide();resilioButton.Hide();firewallCheckbox.Hide();resilioPathCheckbox.Hide();shortcutmakerButton.Hide();
            if (RookiePathExists)
            {
                rookiePathLabel.Text = "";
                LaunchRookie.Hide();
                rookiePathOpen.Hide();
            }
        }


        // Downloads Rookie and extracts the RSL.zip onto the selected install path, if Firewall Checkbox is checked it will automatically add a firewall exception to rookie
        // Firewall checkbox may not work! (As in the method might not work)
        public async void rookieButton_Click(object sender, EventArgs e)
        {
            if (rookieFolderDialog.ShowDialog() == DialogResult.OK)
            {
                selectedPath = rookieFolderDialog.SelectedPath;
                if (firewallCheckbox.Checked)
                {
                    runningProcess = true;
                    downloadProgress.Show();
                    downloadProgress.Invoke((Action)(() => { downloadProgress.Style = ProgressBarStyle.Marquee; }));
                    topLabel.Text = "Downloading Rookie...";
                    topLabel.Refresh();
                    await Downloader.GetRookie();
                    topLabel.Text = "Extracting Rookie...";
                    topLabel.Refresh();
                    await Installer.InstallRookie();
                    topLabel.Text = normalTitle;
                    Buttons.FirewallException();
                    RookiePathExists = true;
                    if (RookiePathExists)
                    {
                        rookiePathLabel.Text = File.ReadLines(@"C:/RSL/RookiePath.txt").First();
                        rookiePathLabel.Refresh();
                        LaunchRookie.Show();
                        rookiePathOpen.Show();
                    }
                    runningProcess = false;
                    MessageBox.Show(messageFinish, captionFinish, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    downloadProgress.Enabled = false;
                    downloadProgress.Hide();
                }
                else
                {
                    runningProcess = true;
                    downloadProgress.Show();
                    downloadProgress.Invoke((Action)(() => { downloadProgress.Style = ProgressBarStyle.Marquee; }));
                    topLabel.Text = "Downloading Rookie...";
                    topLabel.Refresh();
                    await Downloader.GetRookie();
                    topLabel.Text = "Extracting Rookie...";
                    topLabel.Refresh();
                    await Installer.InstallRookie();
                    topLabel.Text = normalTitle;
                    topLabel.Refresh();
                    RookiePathExists = true;
                    if (RookiePathExists)
                    {
                        rookiePathLabel.Text = File.ReadLines(@"C:/RSL/RookiePath.txt").First();
                        rookiePathLabel.Refresh();
                        LaunchRookie.Show();
                        rookiePathOpen.Show();
                    }
                    runningProcess = false;
                    MessageBox.Show(messageFinish, captionFinish, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    downloadProgress.Hide();
                }
            }
        }

        // Downloads VRP GUI
        private async void vrpguiButton_Click(object sender, EventArgs e)
        {
            if (vrpGUIFolderDialog.ShowDialog() == DialogResult.OK)
            {
                runningProcess = true;
                selectedPathVRPGUI = vrpGUIFolderDialog.SelectedPath;
                downloadProgress.Show();
                topLabel.Text = "Downloading VRP GUI...";
                topLabel.Refresh();
                downloadProgress.Invoke((Action)(() => { downloadProgress.Style = ProgressBarStyle.Marquee; }));
                await Downloader.GetVRPGUI();
                topLabel.Text = "Extracting VRP GUI...";
                topLabel.Refresh();
                await Installer.InstallVRPGUI();
                topLabel.Text = normalTitle;
                topLabel.Refresh();
                runningProcess = false;
                MessageBox.Show(messageFinish, captionFinish, MessageBoxButtons.OK, MessageBoxIcon.Information);
                downloadProgress.Hide();
            }
        }

        // Starts the download to Resilio, if checkbox is checked the user is able to select a custom install directory for the setup.exe 
        private async void resilioButton_Click(object sender, EventArgs e)
        {
            if (resilioPathCheckbox.Checked)
            {
                if (resilioFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    runningProcess = true;
                    selectedPathResilio = resilioFolderDialog.SelectedPath;
                    downloadProgress.Show();
                    topLabel.Text = "Downloading Resilio...";
                    topLabel.Refresh();
                    downloadProgress.Invoke((Action)(() => { downloadProgress.Style = ProgressBarStyle.Marquee; }));
                    await Downloader.GetResilio();
                    topLabel.Text = normalTitle;
                    topLabel.Refresh();
                    runningProcess = false;
                    MessageBox.Show(messageFinish, captionFinish, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    downloadProgress.Hide();
                }
            }
            else
            {
                runningProcess = true;
                selectedPathResilio = System.IO.Path.GetTempPath();
                downloadProgress.Show();
                topLabel.Text = "Downloading Resilio...";
                topLabel.Refresh();
                downloadProgress.Invoke((Action)(() => { downloadProgress.Style = ProgressBarStyle.Marquee; }));
                await Downloader.GetResilio();
                topLabel.Text = normalTitle;
                topLabel.Refresh();
                runningProcess = false;
                MessageBox.Show(messageFinish, captionFinish, MessageBoxButtons.OK, MessageBoxIcon.Information);
                downloadProgress.Hide();
            }
        }

        // Downloads Shortcut Maker
        private async void shortcutmakerButton_Click(object sender, EventArgs e)
        {
            if (shortcutmakerFolderDialog.ShowDialog() == DialogResult.OK)
            {
                selectedPathShortcutMaker = shortcutmakerFolderDialog.SelectedPath;
                runningProcess = true;
                downloadProgress.Show();
                downloadProgress.Invoke((Action)(() => { downloadProgress.Style = ProgressBarStyle.Marquee; }));
                topLabel.Text = "Downloading Shortcut Maker...";
                topLabel.Refresh();
                await Downloader.GetShortcutMaker();
                topLabel.Text = "Extracting Shortcut Maker...";
                topLabel.Refresh();
                await Installer.InstallShortcutMaker();
                topLabel.Text = normalTitle;
                topLabel.Refresh();
                runningProcess = false;
                MessageBox.Show(messageFinish, captionFinish, MessageBoxButtons.OK, MessageBoxIcon.Information);
                downloadProgress.Hide();
            }
        }

        // Opens a link to our wiki!
        private void wikiLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://wiki.vrpirates.club/");
        }

        private void LaunchRookie_Click(object sender, EventArgs e)
        {
            Buttons.LaunchRookie();
        }

        // Opens the Path in which Rookie was last installed into.

        private void rookiePathOpen_Click(object sender, EventArgs e)
        {
            try
            {
                Buttons.rookiePathOpener();
            }

            catch (Exception ex)
            {
                string message = $"{ex.Message}";
                string caption = "Error while Launching!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Minimized Rainbow Effect, minimized cuz like cmon we dont need to waste 15 lines for some rainbow effect lol.
        int r = 224, g = 0, b = 0, id;
        int rr = 224, gg = 0, bb = 0;
        private void stopHoverEffect(object sender, EventArgs e){r=224;g=0;b=0;rainbow.Stop();rookieButton.FlatAppearance.BorderColor=Color.FromArgb(34, 34, 34);vrpguiButton.FlatAppearance.BorderColor=Color.FromArgb(34, 34, 34);resilioButton.FlatAppearance.BorderColor=Color.FromArgb(34, 34, 34);LaunchRookie.FlatAppearance.BorderColor=Color.FromArgb(34, 34, 34);rookiePathOpen.FlatAppearance.BorderColor=Color.FromArgb(34, 34, 34);backButton.FlatAppearance.BorderColor = Color.FromArgb(34, 34, 34); nextButton.FlatAppearance.BorderColor = Color.FromArgb(34, 34, 34); shortcutmakerButton.FlatAppearance.BorderColor = Color.FromArgb(34, 34, 34); }
        private void vrpguiButton_MouseHover(object sender, EventArgs e){id=1;rainbow.Start();}
        private void resilioButton_MouseHover(object sender, EventArgs e){id=2;rainbow.Start();}
        private void LaunchRookie_MouseHover(object sender, EventArgs e){id=3;rainbow.Start();}
        private void rainbowBorder_Tick(object sender, EventArgs e){rainbowBorderBottom.BackColor = Color.FromArgb(rr, gg, bb);rainbowBorderTop.BackColor = Color.FromArgb(rr, gg, bb);rainbowBorderLeft.BackColor = Color.FromArgb(rr, gg, bb);rainbowBorderRight.BackColor = Color.FromArgb(rr, gg, bb);if (rr > 0 && bb == 0) { rr--; gg++; }if (gg > 0 && rr == 0) { gg--; bb++; }if (bb > 0 && gg == 0){bb--; rr++;}}
        private void shortcutmakerButton_MouseEnter(object sender, EventArgs e){id = 7; rainbow.Start();}
        private void backButton_MouseEnter(object sender, EventArgs e) { id = 5; rainbow.Start();}
        private void nextButton_MouseEnter(object sender, EventArgs e){id = 6; rainbow.Start();}
        private void rookiePathOpen_MouseHover(object sender, EventArgs e){id=4;rainbow.Start();}
        private void rookieButton_MouseHover(object sender, EventArgs e){id=0;rainbow.Start(); }
        private void rainbow_Tick(object sender, EventArgs e){if(id==0){ rookieButton.FlatAppearance.BorderColor = Color.FromArgb(r, g, b);}if(id==1){vrpguiButton.FlatAppearance.BorderColor=Color.FromArgb(r,g,b);}if(id==2){resilioButton.FlatAppearance.BorderColor=Color.FromArgb(r,g,b);}if(id==3){LaunchRookie.FlatAppearance.BorderColor=Color.FromArgb(r,g,b);}if(id==4){rookiePathOpen.FlatAppearance.BorderColor=Color.FromArgb(r,g,b);}if (id == 5) { backButton.FlatAppearance.BorderColor = Color.FromArgb(r, g, b); }if (id == 6) { nextButton.FlatAppearance.BorderColor = Color.FromArgb(r, g, b);}if (id == 7) { shortcutmakerButton.FlatAppearance.BorderColor = Color.FromArgb(r, g, b); }; if (r>0&&b==0){r--;g++;}if(g>0&&r==0){g--;b++;}if(b>0&&g==0){b--;r++;}
        }
    }
}