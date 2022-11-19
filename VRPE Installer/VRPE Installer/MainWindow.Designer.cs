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
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.rookiePathLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.BackColor = System.Drawing.Color.Transparent;
            this.topLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.Color.White;
            this.topLabel.Location = new System.Drawing.Point(3, 6);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(78, 15);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "VRPE Installer";
            this.topLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.topLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 28);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(823, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(28, 28);
            this.minimizeButton.TabIndex = 1;
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
            this.closeButton.Location = new System.Drawing.Point(857, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 28);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rookiePathLabel);
            this.panel2.Controls.Add(this.LaunchRookie);
            this.panel2.Controls.Add(this.wikiLink);
            this.panel2.Controls.Add(this.resilioPathCheckbox);
            this.panel2.Controls.Add(this.downloadProgress);
            this.panel2.Controls.Add(this.firewallCheckbox);
            this.panel2.Controls.Add(this.resilioButton);
            this.panel2.Controls.Add(this.vrpguiButton);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Controls.Add(this.rookieButton);
            this.panel2.Controls.Add(this.nextButton);
            this.panel2.Controls.Add(this.welcomeLabel);
            this.panel2.Location = new System.Drawing.Point(23, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 359);
            this.panel2.TabIndex = 2;
            // 
            // LaunchRookie
            // 
            this.LaunchRookie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.LaunchRookie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LaunchRookie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LaunchRookie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaunchRookie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchRookie.ForeColor = System.Drawing.Color.White;
            this.LaunchRookie.Location = new System.Drawing.Point(3, 271);
            this.LaunchRookie.Name = "LaunchRookie";
            this.LaunchRookie.Size = new System.Drawing.Size(263, 49);
            this.LaunchRookie.TabIndex = 11;
            this.LaunchRookie.Text = "Launch Rookie";
            this.rookietoolTip.SetToolTip(this.LaunchRookie, "This will download and install Rookie to a selected location.");
            this.LaunchRookie.UseVisualStyleBackColor = false;
            this.LaunchRookie.Visible = false;
            this.LaunchRookie.Click += new System.EventHandler(this.LaunchRookie_Click);
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
            this.resilioPathCheckbox.Location = new System.Drawing.Point(273, 140);
            this.resilioPathCheckbox.Name = "resilioPathCheckbox";
            this.resilioPathCheckbox.Size = new System.Drawing.Size(251, 25);
            this.resilioPathCheckbox.TabIndex = 9;
            this.resilioPathCheckbox.Text = "Select Custom Download Folder";
            this.customFoldertooltip.SetToolTip(this.resilioPathCheckbox, "This will allow you to choose where the Resilio Installer gets downloaded into.");
            this.resilioPathCheckbox.UseVisualStyleBackColor = true;
            this.resilioPathCheckbox.Visible = false;
            // 
            // downloadProgress
            // 
            this.downloadProgress.Location = new System.Drawing.Point(3, 326);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(758, 28);
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
            this.firewallCheckbox.TabIndex = 7;
            this.firewallCheckbox.Text = "Add Firewall Exception on Install";
            this.firewalltoolTip.SetToolTip(this.firewallCheckbox, "This will add a firewall exception for Rookie.");
            this.firewallCheckbox.UseVisualStyleBackColor = false;
            this.firewallCheckbox.Visible = false;
            // 
            // resilioButton
            // 
            this.resilioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.resilioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resilioButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.resilioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resilioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resilioButton.ForeColor = System.Drawing.Color.White;
            this.resilioButton.Location = new System.Drawing.Point(3, 122);
            this.resilioButton.Name = "resilioButton";
            this.resilioButton.Size = new System.Drawing.Size(263, 58);
            this.resilioButton.TabIndex = 6;
            this.resilioButton.Text = "Download and Install \r\nResilio Sync";
            this.resiliotoolTip.SetToolTip(this.resilioButton, "This will install Resilio Sync");
            this.resilioButton.UseVisualStyleBackColor = false;
            this.resilioButton.Visible = false;
            this.resilioButton.Click += new System.EventHandler(this.resilioButton_Click);
            // 
            // vrpguiButton
            // 
            this.vrpguiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.vrpguiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vrpguiButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vrpguiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vrpguiButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrpguiButton.ForeColor = System.Drawing.Color.White;
            this.vrpguiButton.Location = new System.Drawing.Point(3, 58);
            this.vrpguiButton.Name = "vrpguiButton";
            this.vrpguiButton.Size = new System.Drawing.Size(263, 58);
            this.vrpguiButton.TabIndex = 5;
            this.vrpguiButton.Text = "Download and Install VRPGUI";
            this.VRPGUItoolTip.SetToolTip(this.vrpguiButton, "This will download and install VRP GUI to a selected location.");
            this.vrpguiButton.UseVisualStyleBackColor = false;
            this.vrpguiButton.Visible = false;
            this.vrpguiButton.Click += new System.EventHandler(this.vrpguiButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(767, 326);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(72, 28);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // rookieButton
            // 
            this.rookieButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.rookieButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rookieButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rookieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rookieButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rookieButton.ForeColor = System.Drawing.Color.White;
            this.rookieButton.Location = new System.Drawing.Point(3, 3);
            this.rookieButton.Name = "rookieButton";
            this.rookieButton.Size = new System.Drawing.Size(263, 49);
            this.rookieButton.TabIndex = 2;
            this.rookieButton.Text = "Download and Install Rookie";
            this.rookietoolTip.SetToolTip(this.rookieButton, "This will download and install Rookie to a selected location.");
            this.rookieButton.UseVisualStyleBackColor = false;
            this.rookieButton.Visible = false;
            this.rookieButton.Click += new System.EventHandler(this.rookieButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(767, 326);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(72, 28);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "NEXT";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
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
            // rookiePathLabel
            // 
            this.rookiePathLabel.AutoEllipsis = true;
            this.rookiePathLabel.AutoSize = true;
            this.rookiePathLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rookiePathLabel.ForeColor = System.Drawing.Color.White;
            this.rookiePathLabel.Location = new System.Drawing.Point(272, 275);
            this.rookiePathLabel.MaximumSize = new System.Drawing.Size(670, 0);
            this.rookiePathLabel.Name = "rookiePathLabel";
            this.rookiePathLabel.Size = new System.Drawing.Size(0, 15);
            this.rookiePathLabel.TabIndex = 12;
            this.rookiePathLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::VRPE_Installer.Properties.Resources.pattern_cubes_1_1_2_0_0_0_1__000000_171717__1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(891, 502);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "VRPE Installer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
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
    }
}