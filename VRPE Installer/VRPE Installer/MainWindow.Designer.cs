namespace VRPE_Installer
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.topLabel = new System.Windows.Forms.Label();
            this.titleBar = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.shortcutmakerButton = new System.Windows.Forms.Button();
            this.rookiePathOpen = new System.Windows.Forms.Button();
            this.rookiePathLabel = new System.Windows.Forms.Label();
            this.LaunchRookie = new System.Windows.Forms.Button();
            this.wikiLink = new System.Windows.Forms.LinkLabel();
            this.resilioPathCheckbox = new System.Windows.Forms.CheckBox();
            this.downloadProgress = new System.Windows.Forms.ProgressBar();
            this.firewallCheckbox = new System.Windows.Forms.CheckBox();
            this.resilioButton = new System.Windows.Forms.Button();
            this.vrpguiButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.rookieButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.rookieFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.vrpGUIFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.resilioFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.resiliotoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.rookietoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.VRPGUItoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.firewalltoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.customFoldertooltip = new System.Windows.Forms.ToolTip(this.components);
            this.openPathtoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.launchRookietoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.rainbow = new System.Windows.Forms.Timer(this.components);
            this.rainbowBorderTop = new System.Windows.Forms.Panel();
            this.rainbowBorderLeft = new System.Windows.Forms.Panel();
            this.rainbowBorderRight = new System.Windows.Forms.Panel();
            this.rainbowBorderBottom = new System.Windows.Forms.Panel();
            this.rainbowBorder = new System.Windows.Forms.Timer(this.components);
            this.shortcutmakerFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.shortcutmakerToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.titleBar.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.BackColor = System.Drawing.Color.Transparent;
            this.topLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.Color.White;
            this.topLabel.Location = new System.Drawing.Point(10, 7);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(78, 15);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "VRPE Installer";
            this.topLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.titleBar.Controls.Add(this.minimizeButton);
            this.titleBar.Controls.Add(this.closeButton);
            this.titleBar.Controls.Add(this.topLabel);
            this.titleBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleBar.Location = new System.Drawing.Point(-1, -1);
            this.titleBar.Name = "titleBar";
            this.titleBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleBar.Size = new System.Drawing.Size(897, 28);
            this.titleBar.TabIndex = 1;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(806, -2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(28, 22);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(840, -2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 22);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.contentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentPanel.Controls.Add(this.shortcutmakerButton);
            this.contentPanel.Controls.Add(this.rookiePathOpen);
            this.contentPanel.Controls.Add(this.rookiePathLabel);
            this.contentPanel.Controls.Add(this.LaunchRookie);
            this.contentPanel.Controls.Add(this.wikiLink);
            this.contentPanel.Controls.Add(this.resilioPathCheckbox);
            this.contentPanel.Controls.Add(this.downloadProgress);
            this.contentPanel.Controls.Add(this.firewallCheckbox);
            this.contentPanel.Controls.Add(this.resilioButton);
            this.contentPanel.Controls.Add(this.vrpguiButton);
            this.contentPanel.Controls.Add(this.backButton);
            this.contentPanel.Controls.Add(this.rookieButton);
            this.contentPanel.Controls.Add(this.nextButton);
            this.contentPanel.Controls.Add(this.welcomeLabel);
            this.contentPanel.Location = new System.Drawing.Point(23, 80);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(844, 359);
            this.contentPanel.TabIndex = 2;
            // 
            // shortcutmakerButton
            // 
            this.shortcutmakerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.shortcutmakerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shortcutmakerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.shortcutmakerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.shortcutmakerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shortcutmakerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortcutmakerButton.ForeColor = System.Drawing.Color.White;
            this.shortcutmakerButton.Location = new System.Drawing.Point(3, 177);
            this.shortcutmakerButton.Name = "shortcutmakerButton";
            this.shortcutmakerButton.Size = new System.Drawing.Size(263, 58);
            this.shortcutmakerButton.TabIndex = 9;
            this.shortcutmakerButton.Text = "Download and Install \r\nShortcut Maker";
            this.shortcutmakerToolTip.SetToolTip(this.shortcutmakerButton, "This will download and install Shortcut Maker to a selected location.");
            this.shortcutmakerButton.UseVisualStyleBackColor = false;
            this.shortcutmakerButton.Visible = false;
            this.shortcutmakerButton.Click += new System.EventHandler(this.shortcutmakerButton_Click);
            this.shortcutmakerButton.MouseEnter += new System.EventHandler(this.shortcutmakerButton_MouseEnter);
            this.shortcutmakerButton.MouseLeave += new System.EventHandler(this.stopHoverEffect);
            // 
            // rookiePathOpen
            // 
            this.rookiePathOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.rookiePathOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rookiePathOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.rookiePathOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.rookiePathOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rookiePathOpen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rookiePathOpen.ForeColor = System.Drawing.Color.White;
            this.rookiePathOpen.Location = new System.Drawing.Point(3, 292);
            this.rookiePathOpen.Name = "rookiePathOpen";
            this.rookiePathOpen.Size = new System.Drawing.Size(117, 28);
            this.rookiePathOpen.TabIndex = 11;
            this.rookiePathOpen.Text = "Open Path";
            this.openPathtoolTip.SetToolTip(this.rookiePathOpen, "Opens the path of where Rookie was last installed into.");
            this.rookiePathOpen.UseVisualStyleBackColor = false;
            this.rookiePathOpen.Visible = false;
            this.rookiePathOpen.Click += new System.EventHandler(this.rookiePathOpen_Click);
            this.rookiePathOpen.MouseEnter += new System.EventHandler(this.rookiePathOpen_MouseHover);
            this.rookiePathOpen.MouseLeave += new System.EventHandler(this.stopHoverEffect);
            // 
            // rookiePathLabel
            // 
            this.rookiePathLabel.AutoEllipsis = true;
            this.rookiePathLabel.AutoSize = true;
            this.rookiePathLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rookiePathLabel.ForeColor = System.Drawing.Color.White;
            this.rookiePathLabel.Location = new System.Drawing.Point(128, 283);
            this.rookiePathLabel.MaximumSize = new System.Drawing.Size(670, 0);
            this.rookiePathLabel.Name = "rookiePathLabel";
            this.rookiePathLabel.Size = new System.Drawing.Size(0, 15);
            this.rookiePathLabel.TabIndex = 12;
            this.rookiePathLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LaunchRookie
            // 
            this.LaunchRookie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.LaunchRookie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LaunchRookie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.LaunchRookie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.LaunchRookie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaunchRookie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchRookie.ForeColor = System.Drawing.Color.White;
            this.LaunchRookie.Location = new System.Drawing.Point(3, 258);
            this.LaunchRookie.Name = "LaunchRookie";
            this.LaunchRookie.Size = new System.Drawing.Size(117, 28);
            this.LaunchRookie.TabIndex = 10;
            this.LaunchRookie.Text = "Launch Rookie";
            this.launchRookietoolTip.SetToolTip(this.LaunchRookie, "...Launches rookie...who woulda thought...");
            this.LaunchRookie.UseVisualStyleBackColor = false;
            this.LaunchRookie.Visible = false;
            this.LaunchRookie.Click += new System.EventHandler(this.LaunchRookie_Click);
            this.LaunchRookie.MouseEnter += new System.EventHandler(this.LaunchRookie_MouseHover);
            this.LaunchRookie.MouseLeave += new System.EventHandler(this.stopHoverEffect);
            // 
            // wikiLink
            // 
            this.wikiLink.ActiveLinkColor = System.Drawing.Color.Gray;
            this.wikiLink.AutoSize = true;
            this.wikiLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wikiLink.LinkColor = System.Drawing.Color.White;
            this.wikiLink.Location = new System.Drawing.Point(103, 218);
            this.wikiLink.Name = "wikiLink";
            this.wikiLink.Size = new System.Drawing.Size(102, 17);
            this.wikiLink.TabIndex = 10;
            this.wikiLink.TabStop = true;
            this.wikiLink.Text = "Official Wiki Link";
            this.wikiLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.wikiLink_LinkClicked);
            // 
            // resilioPathCheckbox
            // 
            this.resilioPathCheckbox.AutoSize = true;
            this.resilioPathCheckbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resilioPathCheckbox.ForeColor = System.Drawing.Color.White;
            this.resilioPathCheckbox.Location = new System.Drawing.Point(272, 131);
            this.resilioPathCheckbox.Name = "resilioPathCheckbox";
            this.resilioPathCheckbox.Size = new System.Drawing.Size(251, 25);
            this.resilioPathCheckbox.TabIndex = 8;
            this.resilioPathCheckbox.Text = "Select Custom Download Folder";
            this.customFoldertooltip.SetToolTip(this.resilioPathCheckbox, "This will allow you to choose where the Resilio Installer gets downloaded into.");
            this.resilioPathCheckbox.UseVisualStyleBackColor = true;
            this.resilioPathCheckbox.Visible = false;
            // 
            // downloadProgress
            // 
            this.downloadProgress.Location = new System.Drawing.Point(3, 327);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(758, 26);
            this.downloadProgress.TabIndex = 8;
            this.downloadProgress.Visible = false;
            // 
            // firewallCheckbox
            // 
            this.firewallCheckbox.AutoSize = true;
            this.firewallCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.firewallCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firewallCheckbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firewallCheckbox.ForeColor = System.Drawing.Color.White;
            this.firewallCheckbox.Location = new System.Drawing.Point(272, 16);
            this.firewallCheckbox.Name = "firewallCheckbox";
            this.firewallCheckbox.Size = new System.Drawing.Size(252, 25);
            this.firewallCheckbox.TabIndex = 5;
            this.firewallCheckbox.Text = "Add Firewall Exception on Install";
            this.firewalltoolTip.SetToolTip(this.firewallCheckbox, "This will add a firewall exception for Rookie.");
            this.firewallCheckbox.UseVisualStyleBackColor = false;
            this.firewallCheckbox.Visible = false;
            // 
            // resilioButton
            // 
            this.resilioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.resilioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resilioButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.resilioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.resilioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resilioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resilioButton.ForeColor = System.Drawing.Color.White;
            this.resilioButton.Location = new System.Drawing.Point(3, 113);
            this.resilioButton.Name = "resilioButton";
            this.resilioButton.Size = new System.Drawing.Size(263, 58);
            this.resilioButton.TabIndex = 7;
            this.resilioButton.Text = "Download and Install \r\nResilio Sync";
            this.resiliotoolTip.SetToolTip(this.resilioButton, "This will install Resilio Sync");
            this.resilioButton.UseVisualStyleBackColor = false;
            this.resilioButton.Visible = false;
            this.resilioButton.Click += new System.EventHandler(this.resilioButton_Click);
            this.resilioButton.MouseEnter += new System.EventHandler(this.resilioButton_MouseHover);
            this.resilioButton.MouseLeave += new System.EventHandler(this.stopHoverEffect);
            // 
            // vrpguiButton
            // 
            this.vrpguiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.vrpguiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vrpguiButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.vrpguiButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.vrpguiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vrpguiButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrpguiButton.ForeColor = System.Drawing.Color.White;
            this.vrpguiButton.Location = new System.Drawing.Point(3, 58);
            this.vrpguiButton.Name = "vrpguiButton";
            this.vrpguiButton.Size = new System.Drawing.Size(263, 49);
            this.vrpguiButton.TabIndex = 6;
            this.vrpguiButton.Text = "Download and Install VRPGUI";
            this.VRPGUItoolTip.SetToolTip(this.vrpguiButton, "This will download and install VRP GUI to a selected location.");
            this.vrpguiButton.UseVisualStyleBackColor = false;
            this.vrpguiButton.Visible = false;
            this.vrpguiButton.Click += new System.EventHandler(this.vrpguiButton_Click);
            this.vrpguiButton.MouseEnter += new System.EventHandler(this.vrpguiButton_MouseHover);
            this.vrpguiButton.MouseLeave += new System.EventHandler(this.stopHoverEffect);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(767, 326);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(72, 28);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.stopHoverEffect);
            // 
            // rookieButton
            // 
            this.rookieButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.rookieButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rookieButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.rookieButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.rookieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rookieButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rookieButton.ForeColor = System.Drawing.Color.White;
            this.rookieButton.Location = new System.Drawing.Point(3, 3);
            this.rookieButton.Name = "rookieButton";
            this.rookieButton.Size = new System.Drawing.Size(263, 49);
            this.rookieButton.TabIndex = 4;
            this.rookieButton.Text = "Download and Install Rookie";
            this.rookietoolTip.SetToolTip(this.rookieButton, "This will download and install Rookie to a selected location.");
            this.rookieButton.UseVisualStyleBackColor = false;
            this.rookieButton.Visible = false;
            this.rookieButton.Click += new System.EventHandler(this.rookieButton_Click);
            this.rookieButton.MouseEnter += new System.EventHandler(this.rookieButton_MouseHover);
            this.rookieButton.MouseLeave += new System.EventHandler(this.stopHoverEffect);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(767, 326);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(72, 28);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = "NEXT";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            this.nextButton.MouseEnter += new System.EventHandler(this.nextButton_MouseEnter);
            this.nextButton.MouseLeave += new System.EventHandler(this.stopHoverEffect);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(100, 112);
            this.welcomeLabel.MaximumSize = new System.Drawing.Size(650, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(645, 96);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to the official VRPE Installer, the next step will let you choose which p" +
    "rograms you want to install from our suite. ";
            // 
            // rookieFolderDialog
            // 
            this.rookieFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // vrpGUIFolderDialog
            // 
            this.vrpGUIFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // resilioFolderDialog
            // 
            this.resilioFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // resiliotoolTip
            // 
            this.resiliotoolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.resiliotoolTip.ToolTipTitle = "Downloads";
            // 
            // rookietoolTip
            // 
            this.rookietoolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.rookietoolTip.ToolTipTitle = "Downloads";
            // 
            // VRPGUItoolTip
            // 
            this.VRPGUItoolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.VRPGUItoolTip.ToolTipTitle = "Downloads";
            // 
            // firewalltoolTip
            // 
            this.firewalltoolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.firewalltoolTip.ToolTipTitle = "Selections";
            // 
            // customFoldertooltip
            // 
            this.customFoldertooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.customFoldertooltip.ToolTipTitle = "Selections";
            // 
            // rainbow
            // 
            this.rainbow.Interval = 5;
            this.rainbow.Tick += new System.EventHandler(this.rainbow_Tick);
            // 
            // rainbowBorderTop
            // 
            this.rainbowBorderTop.BackColor = System.Drawing.Color.White;
            this.rainbowBorderTop.Location = new System.Drawing.Point(23, 80);
            this.rainbowBorderTop.Name = "rainbowBorderTop";
            this.rainbowBorderTop.Size = new System.Drawing.Size(844, 1);
            this.rainbowBorderTop.TabIndex = 14;
            // 
            // rainbowBorderLeft
            // 
            this.rainbowBorderLeft.BackColor = System.Drawing.Color.White;
            this.rainbowBorderLeft.Location = new System.Drawing.Point(23, 80);
            this.rainbowBorderLeft.Name = "rainbowBorderLeft";
            this.rainbowBorderLeft.Size = new System.Drawing.Size(1, 359);
            this.rainbowBorderLeft.TabIndex = 14;
            // 
            // rainbowBorderRight
            // 
            this.rainbowBorderRight.BackColor = System.Drawing.Color.White;
            this.rainbowBorderRight.Location = new System.Drawing.Point(866, 80);
            this.rainbowBorderRight.Name = "rainbowBorderRight";
            this.rainbowBorderRight.Size = new System.Drawing.Size(1, 359);
            this.rainbowBorderRight.TabIndex = 15;
            // 
            // rainbowBorderBottom
            // 
            this.rainbowBorderBottom.BackColor = System.Drawing.Color.White;
            this.rainbowBorderBottom.Location = new System.Drawing.Point(23, 438);
            this.rainbowBorderBottom.Name = "rainbowBorderBottom";
            this.rainbowBorderBottom.Size = new System.Drawing.Size(844, 1);
            this.rainbowBorderBottom.TabIndex = 15;
            // 
            // rainbowBorder
            // 
            this.rainbowBorder.Interval = 5;
            this.rainbowBorder.Tick += new System.EventHandler(this.rainbowBorder_Tick);
            // 
            // shortcutmakerFolderDialog
            // 
            this.shortcutmakerFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // shortcutmakerToolTip
            // 
            this.shortcutmakerToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.shortcutmakerToolTip.ToolTipTitle = "Downloads";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.BackgroundImage = global::VRPE_Installer.Properties.Resources.pattern_cubes_1_1_1_0_0_0_1__000000_212121;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(891, 502);
            this.Controls.Add(this.rainbowBorderBottom);
            this.Controls.Add(this.rainbowBorderRight);
            this.Controls.Add(this.rainbowBorderLeft);
            this.Controls.Add(this.rainbowBorderTop);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.titleBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VRPE Installer";
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button rookieButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button resilioButton;
        private System.Windows.Forms.Button vrpguiButton;
        private System.Windows.Forms.CheckBox firewallCheckbox;
        private System.Windows.Forms.FolderBrowserDialog rookieFolderDialog;
        public System.Windows.Forms.ProgressBar downloadProgress;
        private System.Windows.Forms.FolderBrowserDialog vrpGUIFolderDialog;
        private System.Windows.Forms.FolderBrowserDialog resilioFolderDialog;
        private System.Windows.Forms.CheckBox resilioPathCheckbox;
        private System.Windows.Forms.LinkLabel wikiLink;
        private System.Windows.Forms.ToolTip resiliotoolTip;
        private System.Windows.Forms.ToolTip rookietoolTip;
        private System.Windows.Forms.ToolTip VRPGUItoolTip;
        private System.Windows.Forms.ToolTip customFoldertooltip;
        private System.Windows.Forms.ToolTip firewalltoolTip;
        private System.Windows.Forms.Button LaunchRookie;
        private System.Windows.Forms.Label rookiePathLabel;
        private System.Windows.Forms.Button rookiePathOpen;
        private System.Windows.Forms.ToolTip openPathtoolTip;
        private System.Windows.Forms.ToolTip launchRookietoolTip;
        private System.Windows.Forms.Timer rainbow;
        private System.Windows.Forms.Panel rainbowBorderTop;
        private System.Windows.Forms.Panel rainbowBorderLeft;
        private System.Windows.Forms.Panel rainbowBorderRight;
        private System.Windows.Forms.Panel rainbowBorderBottom;
        private System.Windows.Forms.Timer rainbowBorder;
        private System.Windows.Forms.FolderBrowserDialog shortcutmakerFolderDialog;
        private System.Windows.Forms.Button shortcutmakerButton;
        private System.Windows.Forms.ToolTip shortcutmakerToolTip;
    }
}