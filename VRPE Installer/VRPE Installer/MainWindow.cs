using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace VRPE_Installer
{
    public partial class MainWindow : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")] public static extern bool ReleaseCapture(); [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public static string fixPath = @"\";
        public string normalTitle = "VRPE Installer";
        public static bool RSLPathExists;
        public static bool RookiePathExists;
        public static bool VRPGUIPathExists;
        public static bool runningProcess;
        // On Program start, set the RSL Path, create an HTTP Client to fetch the version number of Rookie and set the string, set bools true if files exist.
        public MainWindow()
        {
            var RSLPATH = @"C:\RSL\";
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            rainbowBorder.Start();
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
            flowPanel.Show(); wikiLink.Hide(); welcomeLabel.Hide(); backButton.Show(); nextButton.Hide(); rookieButton.Show(); vrpguiButton.Show(); resilioButton.Show(); resilioPathCheckbox.Show(); shortcutmakerButton.Show();
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
            flowPanel.Hide(); wikiLink.Show(); backButton.Hide(); nextButton.Show(); welcomeLabel.Show(); rookieButton.Hide(); vrpguiButton.Hide(); resilioButton.Hide(); resilioPathCheckbox.Hide(); shortcutmakerButton.Hide();
            if (RookiePathExists)
            {
                rookiePathLabel.Text = "";
                LaunchRookie.Hide();
                rookiePathOpen.Hide();
            }
        }

        // Downloads Rookie and extracts the RSL.zip onto the selected install path.
        public async void rookieButton_Click(object sender, EventArgs e)
        {
            bool success;
            var neededIcon = "https://wiki.vrpirates.club/downloads/rookie.ico";
            var RSLPATH = @"C:\RSL\";
            if (rookieFolderDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedPath = rookieFolderDialog.SelectedPath;
                if (selectedPath.Contains("OneDrive"))
                {
                    DialogResult dialogResult = MessageBox.Show("VRPE has detected a OneDrive Path!\nAs OneDrive breaks Rookie the VRPE will not continue downloading.", "OneDrive Path Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var ver = Program.HttpClient.GetStringAsync("https://raw.githubusercontent.com/nerdunit/androidsideloader/master/version").Result;
                runningProcess = true;
                EnableProcessbar(sender, e);
                topLabel.Text = "Downloading Rookie...";
                topLabel.Refresh();
                success = await Downloader.GetRookie(selectedPath, fixPath);
                topLabel.Text = "Extracting Rookie...";
                topLabel.Refresh();
                success = await Installer.InstallRookie(selectedPath, ver, fixPath);
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
                downloadProgress.Hide();
                if (success)
                {
                    DialogResult dialogResult = MessageBox.Show("Would you like to create a desktop shortcut and launch Rookie?", "Create Desktop Shortcut", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        success = await Downloader.GetIcons(RSLPATH, "ROOKIE.ico", neededIcon);
                        ShortcutMaker.CreateShortcutRookie(selectedPath, fixPath, ver);
                        Buttons.LaunchRookie();
                    }
                    if (success)
                    {
                        MessageBoxes.Finish();
                    }
                }
            }
        }

        // Downloads VRP GUI
        private async void vrpguiButton_Click(object sender, EventArgs e)
        {
            bool success;
            var neededIcon = "https://wiki.vrpirates.club/downloads/rclone.ico";
            var RSLPATH = @"C:\RSL\";
            if (vrpGUIFolderDialog.ShowDialog() == DialogResult.OK)
            {
                runningProcess = true;
                var selectedPathVRPGUI = vrpGUIFolderDialog.SelectedPath;
                topLabel.Text = "Downloading VRP GUI...";
                topLabel.Refresh();
                EnableProcessbar(sender, e);
                success = await Downloader.GetIcons(RSLPATH, "RCLONE.ico", neededIcon);
                success = await Downloader.GetVRPGUI(selectedPathVRPGUI, fixPath);
                topLabel.Text = "Extracting VRP GUI...";
                topLabel.Refresh();
                success = await Installer.InstallVRPGUI(selectedPathVRPGUI, fixPath);
                ShortcutMaker.CreateShortcutVRPGUI(selectedPathVRPGUI, fixPath);
                topLabel.Text = normalTitle;
                topLabel.Refresh();
                runningProcess = false;
                downloadProgress.Hide();
                if (success)
                {
                    MessageBoxes.Finish();
                }
            }
        }

        // Starts the download to Resilio, if checkbox is checked the user is able to select a custom install directory for the setup.exe 
        private async void resilioButton_Click(object sender, EventArgs e)
        {
            bool success;
            if (resilioPathCheckbox.Checked)
            {
                if (resilioFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    runningProcess = true;
                    var selectedPathResilio = resilioFolderDialog.SelectedPath;
                    topLabel.Text = "Downloading Resilio...";
                    topLabel.Refresh();
                    EnableProcessbar(sender, e);
                    success = await Downloader.GetResilio(selectedPathResilio, fixPath);
                    topLabel.Text = normalTitle;
                    topLabel.Refresh();
                    runningProcess = false;
                    downloadProgress.Hide();
                    if (success)
                    {
                        MessageBoxes.Finish();
                    }
                }
            }
            else
            {
                runningProcess = true;
                var selectedPathResilio = System.IO.Path.GetTempPath();
                topLabel.Text = "Downloading Resilio...";
                topLabel.Refresh();
                EnableProcessbar(sender, e);
                success = await Downloader.GetResilio(selectedPathResilio, fixPath);
                topLabel.Text = normalTitle;
                topLabel.Refresh();
                runningProcess = false;
                downloadProgress.Hide();
                if (success)
                {
                    MessageBoxes.Finish();
                }
            }
        }

        // Shows the progressbar and enables its animation
        private void EnableProcessbar(object sender, EventArgs e)
        {
            downloadProgress.Show();
            downloadProgress.Invoke((Action)(() => { downloadProgress.Style = ProgressBarStyle.Marquee; }));
        }

        // Downloads Shortcut Maker
        private async void shortcutmakerButton_Click(object sender, EventArgs e)
        {
            bool success;
            var neededIcon = "https://wiki.vrpirates.club/downloads/sm.ico";
            var RSLPATH = @"C:\RSL\";
            if (shortcutmakerFolderDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedPathShortcutMaker = shortcutmakerFolderDialog.SelectedPath;
                runningProcess = true;
                EnableProcessbar(sender, e);
                topLabel.Text = "Downloading Shortcut Maker...";
                topLabel.Refresh();
                success = await Downloader.GetIcons(RSLPATH, "SM.ico", neededIcon);
                success = await Downloader.GetShortcutMaker(selectedPathShortcutMaker, fixPath);
                topLabel.Text = "Extracting Shortcut Maker...";
                topLabel.Refresh();
                success = await Installer.InstallShortcutMaker(selectedPathShortcutMaker, fixPath);
                ShortcutMaker.CreateShortcutShortcutMaker(selectedPathShortcutMaker, fixPath);
                topLabel.Text = normalTitle;
                topLabel.Refresh();
                runningProcess = false;
                downloadProgress.Hide();
                if (success)
                {
                    MessageBoxes.Finish();
                }
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
                string caption = "Error while opening!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Minimized Rainbow Effect, minimized cuz like cmon we dont need to waste 15 lines for some rainbow effect lol.
        int r = 224, g = 0, b = 0, id;
        int rr = 224, gg = 0, bb = 0;
        private void stopHoverEffect(object sender, EventArgs e) { r = 224; g = 0; b = 0; rainbow.Stop(); rookieButton.FlatAppearance.BorderColor = Color.FromArgb(34, 34, 34); vrpguiButton.FlatAppearance.BorderColor = Color.FromArgb(34, 34, 34); resilioButton.FlatAppearance.BorderColor = Color.FromArgb(34, 34, 34); LaunchRookie.FlatAppearance.BorderColor = Color.FromArgb(34, 34, 34); rookiePathOpen.FlatAppearance.BorderColor = Color.FromArgb(34, 34, 34); backButton.FlatAppearance.BorderColor = Color.FromArgb(34, 34, 34); nextButton.FlatAppearance.BorderColor = Color.FromArgb(34, 34, 34); shortcutmakerButton.FlatAppearance.BorderColor = Color.FromArgb(34, 34, 34); }
        private void vrpguiButton_MouseHover(object sender, EventArgs e) { id = 1; rainbow.Start(); }
        private void resilioButton_MouseHover(object sender, EventArgs e) { id = 2; rainbow.Start(); }
        private void LaunchRookie_MouseHover(object sender, EventArgs e) { id = 3; rainbow.Start(); }
        private void rainbowBorder_Tick(object sender, EventArgs e) { rainbowBorderBottom.BackColor = Color.FromArgb(rr, gg, bb); rainbowBorderTop.BackColor = Color.FromArgb(rr, gg, bb); rainbowBorderLeft.BackColor = Color.FromArgb(rr, gg, bb); rainbowBorderRight.BackColor = Color.FromArgb(rr, gg, bb); if (rr > 0 && bb == 0) { rr--; gg++; } if (gg > 0 && rr == 0) { gg--; bb++; } if (bb > 0 && gg == 0) { bb--; rr++; } }
        private void shortcutmakerButton_MouseEnter(object sender, EventArgs e) { id = 7; rainbow.Start(); }
        private void backButton_MouseEnter(object sender, EventArgs e) { id = 5; rainbow.Start(); }
        private void nextButton_MouseEnter(object sender, EventArgs e) { id = 6; rainbow.Start(); }
        private void rookiePathOpen_MouseHover(object sender, EventArgs e) { id = 4; rainbow.Start(); }
        private void rookieButton_MouseHover(object sender, EventArgs e) { id = 0; rainbow.Start(); }
        private void rainbow_Tick(object sender, EventArgs e)
        {
            if (id == 0) { rookieButton.FlatAppearance.BorderColor = Color.FromArgb(r, g, b); }
            if (id == 1) { vrpguiButton.FlatAppearance.BorderColor = Color.FromArgb(r, g, b); }
            if (id == 2) { resilioButton.FlatAppearance.BorderColor = Color.FromArgb(r, g, b); }
            if (id == 3) { LaunchRookie.FlatAppearance.BorderColor = Color.FromArgb(r, g, b); }
            if (id == 4) { rookiePathOpen.FlatAppearance.BorderColor = Color.FromArgb(r, g, b); }
            if (id == 5) { backButton.FlatAppearance.BorderColor = Color.FromArgb(r, g, b); }
            if (id == 6) { nextButton.FlatAppearance.BorderColor = Color.FromArgb(r, g, b); }
            if (id == 7) { shortcutmakerButton.FlatAppearance.BorderColor = Color.FromArgb(r, g, b); }; if (r > 0 && b == 0) { r--; g++; }
            if (g > 0 && r == 0) { g--; b++; }
            if (b > 0 && g == 0) { b--; r++; }
        }
    }
}