namespace VRPE_Installer
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resilioButton = new System.Windows.Forms.Button();
            this.vrpguiButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.rookieButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.firewallCheckbox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "VRPE Installer";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 33);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(809, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(35, 33);
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
            this.closeButton.Font = new System.Drawing.Font("Roboto Mono Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(850, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 33);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.firewallCheckbox);
            this.panel2.Controls.Add(this.resilioButton);
            this.panel2.Controls.Add(this.vrpguiButton);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Controls.Add(this.rookieButton);
            this.panel2.Controls.Add(this.nextButton);
            this.panel2.Controls.Add(this.welcomeLabel);
            this.panel2.Location = new System.Drawing.Point(23, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 359);
            this.panel2.TabIndex = 2;
            // 
            // resilioButton
            // 
            this.resilioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.resilioButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.resilioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resilioButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resilioButton.ForeColor = System.Drawing.Color.White;
            this.resilioButton.Location = new System.Drawing.Point(3, 122);
            this.resilioButton.Name = "resilioButton";
            this.resilioButton.Size = new System.Drawing.Size(263, 58);
            this.resilioButton.TabIndex = 6;
            this.resilioButton.Text = "Download and Install \r\nResilio Sync";
            this.resilioButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resilioButton.UseVisualStyleBackColor = false;
            this.resilioButton.Visible = false;
            // 
            // vrpguiButton
            // 
            this.vrpguiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.vrpguiButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vrpguiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vrpguiButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrpguiButton.ForeColor = System.Drawing.Color.White;
            this.vrpguiButton.Location = new System.Drawing.Point(3, 58);
            this.vrpguiButton.Name = "vrpguiButton";
            this.vrpguiButton.Size = new System.Drawing.Size(263, 58);
            this.vrpguiButton.TabIndex = 5;
            this.vrpguiButton.Text = "Download and Install VRPGUI";
            this.vrpguiButton.UseVisualStyleBackColor = false;
            this.vrpguiButton.Visible = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(3, 326);
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
            this.rookieButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rookieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rookieButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rookieButton.ForeColor = System.Drawing.Color.White;
            this.rookieButton.Location = new System.Drawing.Point(3, 3);
            this.rookieButton.Name = "rookieButton";
            this.rookieButton.Size = new System.Drawing.Size(263, 49);
            this.rookieButton.TabIndex = 2;
            this.rookieButton.Text = "Download and Install Rookie";
            this.rookieButton.UseVisualStyleBackColor = false;
            this.rookieButton.Visible = false;
            this.rookieButton.Click += new System.EventHandler(this.rookieButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.nextButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(767, 326);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(72, 28);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "NEXT";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(104, 129);
            this.welcomeLabel.MaximumSize = new System.Drawing.Size(650, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(645, 87);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to the official VRPE Installer, the next step will let you choose which p" +
    "rograms you want to install from our suite. ";
            // 
            // firewallCheckbox
            // 
            this.firewallCheckbox.AutoSize = true;
            this.firewallCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.firewallCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firewallCheckbox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firewallCheckbox.ForeColor = System.Drawing.Color.White;
            this.firewallCheckbox.Location = new System.Drawing.Point(272, 16);
            this.firewallCheckbox.Name = "firewallCheckbox";
            this.firewallCheckbox.Size = new System.Drawing.Size(257, 23);
            this.firewallCheckbox.TabIndex = 7;
            this.firewallCheckbox.Text = "Add Firewall Exception on Install";
            this.firewallCheckbox.UseVisualStyleBackColor = false;
            this.firewallCheckbox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::VRPE_Installer.Properties.Resources.pattern_cubes_1_1_2_0_0_0_1__000000_171717__1_1;
            this.ClientSize = new System.Drawing.Size(891, 502);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
    }
}

