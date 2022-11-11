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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rookieflowoutpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RookieCheckbox = new System.Windows.Forms.CheckBox();
            this.FirewallCheckbox = new System.Windows.Forms.CheckBox();
            this.ResilioCheckbox = new System.Windows.Forms.CheckBox();
            this.RcloneCheckbox = new System.Windows.Forms.CheckBox();
            this.FirewallToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.InstallPath = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.rookieflowoutpanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nunito", 35.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "VRPE Installer";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 23);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.InstallPath);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.rookieflowoutpanel);
            this.panel2.Location = new System.Drawing.Point(23, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 358);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.flowLayoutPanel1.Controls.Add(this.RcloneCheckbox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 101);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(298, 44);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel3.Location = new System.Drawing.Point(-1, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 23);
            this.panel3.TabIndex = 3;
            // 
            // rookieflowoutpanel
            // 
            this.rookieflowoutpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.rookieflowoutpanel.Controls.Add(this.RookieCheckbox);
            this.rookieflowoutpanel.Controls.Add(this.FirewallCheckbox);
            this.rookieflowoutpanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.rookieflowoutpanel.Location = new System.Drawing.Point(-1, -1);
            this.rookieflowoutpanel.Name = "rookieflowoutpanel";
            this.rookieflowoutpanel.Size = new System.Drawing.Size(298, 83);
            this.rookieflowoutpanel.TabIndex = 0;
            // 
            // RookieCheckbox
            // 
            this.RookieCheckbox.AutoSize = true;
            this.RookieCheckbox.Font = new System.Drawing.Font("Nunito ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RookieCheckbox.ForeColor = System.Drawing.Color.White;
            this.RookieCheckbox.Location = new System.Drawing.Point(3, 3);
            this.RookieCheckbox.Name = "RookieCheckbox";
            this.RookieCheckbox.Size = new System.Drawing.Size(166, 33);
            this.RookieCheckbox.TabIndex = 0;
            this.RookieCheckbox.Text = "Install Rookie";
            this.RookieCheckbox.UseVisualStyleBackColor = true;
            // 
            // FirewallCheckbox
            // 
            this.FirewallCheckbox.AutoSize = true;
            this.FirewallCheckbox.Font = new System.Drawing.Font("Nunito ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirewallCheckbox.ForeColor = System.Drawing.Color.White;
            this.FirewallCheckbox.Location = new System.Drawing.Point(3, 42);
            this.FirewallCheckbox.Name = "FirewallCheckbox";
            this.FirewallCheckbox.Size = new System.Drawing.Size(261, 33);
            this.FirewallCheckbox.TabIndex = 3;
            this.FirewallCheckbox.Text = "Add Firewall Exception";
            this.FirewallToolTip.SetToolTip(this.FirewallCheckbox, "Adds a Firewall Exception for Rookie to prevent issues with downloading.");
            this.FirewallCheckbox.UseVisualStyleBackColor = true;
            // 
            // ResilioCheckbox
            // 
            this.ResilioCheckbox.AutoSize = true;
            this.ResilioCheckbox.Font = new System.Drawing.Font("Nunito ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResilioCheckbox.ForeColor = System.Drawing.Color.White;
            this.ResilioCheckbox.Location = new System.Drawing.Point(3, 3);
            this.ResilioCheckbox.Name = "ResilioCheckbox";
            this.ResilioCheckbox.Size = new System.Drawing.Size(164, 33);
            this.ResilioCheckbox.TabIndex = 2;
            this.ResilioCheckbox.Text = "Install Resilio";
            this.ResilioCheckbox.UseVisualStyleBackColor = true;
            // 
            // RcloneCheckbox
            // 
            this.RcloneCheckbox.AutoSize = true;
            this.RcloneCheckbox.Font = new System.Drawing.Font("Nunito ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RcloneCheckbox.ForeColor = System.Drawing.Color.White;
            this.RcloneCheckbox.Location = new System.Drawing.Point(3, 3);
            this.RcloneCheckbox.Name = "RcloneCheckbox";
            this.RcloneCheckbox.Size = new System.Drawing.Size(176, 33);
            this.RcloneCheckbox.TabIndex = 1;
            this.RcloneCheckbox.Text = "Install VRPGui";
            this.RcloneCheckbox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(23, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(844, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "DOWNLOAD AND INSTALL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel4.Location = new System.Drawing.Point(-1, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 23);
            this.panel4.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.flowLayoutPanel2.Controls.Add(this.ResilioCheckbox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(-1, 164);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(298, 39);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panel5.Location = new System.Drawing.Point(-1, 200);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 23);
            this.panel5.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(-1, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "DOWNLOAD LATEST CONFIG FILES";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // InstallPath
            // 
            this.InstallPath.AutoSize = true;
            this.InstallPath.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallPath.ForeColor = System.Drawing.Color.White;
            this.InstallPath.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.InstallPath.Location = new System.Drawing.Point(3, 255);
            this.InstallPath.Name = "InstallPath";
            this.InstallPath.Size = new System.Drawing.Size(283, 58);
            this.InstallPath.TabIndex = 6;
            this.InstallPath.Text = "Installs will go to \r\nC:/Program Files (x86)/VRP";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Nunito", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(872, -2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Nunito", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(847, -2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::VRPE_Installer.Properties.Resources.pattern_cubes_1_1_1_0_0_0_1__000000_212121;
            this.ClientSize = new System.Drawing.Size(891, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.rookieflowoutpanel.ResumeLayout(false);
            this.rookieflowoutpanel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel rookieflowoutpanel;
        private System.Windows.Forms.CheckBox RookieCheckbox;
        private System.Windows.Forms.CheckBox RcloneCheckbox;
        private System.Windows.Forms.CheckBox ResilioCheckbox;
        private System.Windows.Forms.CheckBox FirewallCheckbox;
        private System.Windows.Forms.ToolTip FirewallToolTip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label InstallPath;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
    }
}

