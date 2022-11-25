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
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private Random rnd = new Random();
        public static string selectedPath;
        public static string selectedPathVRPGUI;
        public static string selectedPathResilio;
        public static string fixPath = @"\";
        public static string ver;
        public string normalTitle = "VRPE Installer";
        public string captionFinish = "Done!";
        public string messageFinish = "Downloading & Extracting Finished";
        public static bool RSLPathExists;
        public static bool RookiePathExists;
        public static bool VRPGUIPathExists;

        // On Program start, set the RSL Path, create an HTTP Client to fetch the version number of Rookie and set the string, set bools true if files exist.

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public MainWindow()
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 891, 502, 25, 25));
            var RSLPATH = @"C:\RSL\";
            HttpClient client = new HttpClient();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
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
            Application.Exit();
            Close();
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
                    if (RookiePathExists)
                    {
                        rookiePathLabel.Text = File.ReadLines(@"C:/RSL/RookiePath.txt").First();
                        rookiePathLabel.Refresh();
                        LaunchRookie.Show();
                        rookiePathOpen.Show();
                    }
                    MessageBox.Show(messageFinish, captionFinish, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    topLabel.Text = normalTitle;
                    topLabel.Refresh();
                    if (RookiePathExists)
                    {
                        rookiePathLabel.Text = File.ReadLines(@"C:/RSL/RookiePath.txt").First();
                        rookiePathLabel.Refresh();
                        LaunchRookie.Show();
                        rookiePathOpen.Show();
                    }
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
                    selectedPathResilio = resilioFolderDialog.SelectedPath;
                    downloadProgress.Show();
                    topLabel.Text = "Downloading Resilio...";
                    topLabel.Refresh();
                    downloadProgress.Invoke((Action)(() => { downloadProgress.Style = ProgressBarStyle.Marquee; }));
                    await Downloader.GetResilio();
                    topLabel.Text = normalTitle;
                    topLabel.Refresh();
                    MessageBox.Show(messageFinish, captionFinish, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    downloadProgress.Hide();
                }
            }
            else
            {
                selectedPathResilio = System.IO.Path.GetTempPath();
                downloadProgress.Show();
                topLabel.Text = "Downloading Resilio...";
                topLabel.Refresh();
                downloadProgress.Invoke((Action)(() => { downloadProgress.Style = ProgressBarStyle.Marquee; }));
                await Downloader.GetResilio();
                topLabel.Text = normalTitle;
                topLabel.Refresh();
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
        public int r = 224, g = 0, b = 0, id;
        private void stopHoverEffect(object sender, EventArgs e){r=224;g=0;b=0;rainbow.Stop();rookieButton.FlatAppearance.BorderColor=Color.FromArgb(224,224,224);vrpguiButton.FlatAppearance.BorderColor=Color.FromArgb(224,224,224);resilioButton.FlatAppearance.BorderColor=Color.FromArgb(224,224,224);LaunchRookie.FlatAppearance.BorderColor=Color.FromArgb(224,224,224);rookiePathOpen.FlatAppearance.BorderColor=Color.FromArgb(224,224,224);}
        private void vrpguiButton_MouseHover(object sender, EventArgs e){id=1;rainbow.Start();}
        private void resilioButton_MouseHover(object sender, EventArgs e){id=2;rainbow.Start();}
        private void LaunchRookie_MouseHover(object sender, EventArgs e){id=3;rainbow.Start();}
        private void rookiePathOpen_MouseHover(object sender, EventArgs e){id=4;rainbow.Start();}
        private void rookieButton_MouseHover(object sender, EventArgs e){id=0;rainbow.Start();}
        private void rainbow_Tick(object sender, EventArgs e){if(id==0){rookieButton.FlatAppearance.BorderColor=Color.FromArgb(r,g,b);}if(id==1){vrpguiButton.FlatAppearance.BorderColor=Color.FromArgb(r,g,b);}if(id==2){resilioButton.FlatAppearance.BorderColor=Color.FromArgb(r,g,b);}if(id==3){LaunchRookie.FlatAppearance.BorderColor=Color.FromArgb(r,g,b);}if(id==4){rookiePathOpen.FlatAppearance.BorderColor=Color.FromArgb(r,g,b);}if(r>0&&b==0){r--;g++;}if(g>0&&r==0){g--;b++;}if(b>0&&g==0){b--;r++;}
        }
    }
}