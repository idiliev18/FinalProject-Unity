namespace GameLauncher
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginFromPanel = new System.Windows.Forms.Panel();
            this.LoginFailedLabel = new System.Windows.Forms.Label();
            this.ShortPassLabel = new System.Windows.Forms.Label();
            this.AllReqLabel = new System.Windows.Forms.Label();
            this.AccountYok = new System.Windows.Forms.LinkLabel();
            this.ForgotPass = new System.Windows.Forms.LinkLabel();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.PassLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.HRPanelPassword = new System.Windows.Forms.Panel();
            this.HRPanelUsername = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LoginFromPanel.SuspendLayout();
            this.HRPanelUsername.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginFromPanel
            // 
            this.LoginFromPanel.BackColor = System.Drawing.SystemColors.Control;
            this.LoginFromPanel.Controls.Add(this.LoginFailedLabel);
            this.LoginFromPanel.Controls.Add(this.ShortPassLabel);
            this.LoginFromPanel.Controls.Add(this.AllReqLabel);
            this.LoginFromPanel.Controls.Add(this.AccountYok);
            this.LoginFromPanel.Controls.Add(this.ForgotPass);
            this.LoginFromPanel.Controls.Add(this.LogInBtn);
            this.LoginFromPanel.Controls.Add(this.PassLabel);
            this.LoginFromPanel.Controls.Add(this.UsernameLabel);
            this.LoginFromPanel.Controls.Add(this.PasswordTextBox);
            this.LoginFromPanel.Controls.Add(this.UsernameTextBox);
            this.LoginFromPanel.Controls.Add(this.HRPanelPassword);
            this.LoginFromPanel.Controls.Add(this.HRPanelUsername);
            this.LoginFromPanel.Controls.Add(this.TitlePanel);
            this.LoginFromPanel.Location = new System.Drawing.Point(304, 48);
            this.LoginFromPanel.Name = "LoginFromPanel";
            this.LoginFromPanel.Size = new System.Drawing.Size(300, 450);
            this.LoginFromPanel.TabIndex = 0;
            // 
            // LoginFailedLabel
            // 
            this.LoginFailedLabel.AutoSize = true;
            this.LoginFailedLabel.ForeColor = System.Drawing.Color.Red;
            this.LoginFailedLabel.Location = new System.Drawing.Point(105, 355);
            this.LoginFailedLabel.Name = "LoginFailedLabel";
            this.LoginFailedLabel.Size = new System.Drawing.Size(0, 13);
            this.LoginFailedLabel.TabIndex = 12;
            this.LoginFailedLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // ShortPassLabel
            // 
            this.ShortPassLabel.AutoSize = true;
            this.ShortPassLabel.ForeColor = System.Drawing.Color.Red;
            this.ShortPassLabel.Location = new System.Drawing.Point(51, 355);
            this.ShortPassLabel.Name = "ShortPassLabel";
            this.ShortPassLabel.Size = new System.Drawing.Size(0, 13);
            this.ShortPassLabel.TabIndex = 11;
            // 
            // AllReqLabel
            // 
            this.AllReqLabel.AutoSize = true;
            this.AllReqLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllReqLabel.ForeColor = System.Drawing.Color.Red;
            this.AllReqLabel.Location = new System.Drawing.Point(86, 356);
            this.AllReqLabel.Name = "AllReqLabel";
            this.AllReqLabel.Size = new System.Drawing.Size(0, 13);
            this.AllReqLabel.TabIndex = 10;
            // 
            // AccountYok
            // 
            this.AccountYok.AutoSize = true;
            this.AccountYok.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.AccountYok.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AccountYok.Location = new System.Drawing.Point(6, 423);
            this.AccountYok.Name = "AccountYok";
            this.AccountYok.Size = new System.Drawing.Size(108, 13);
            this.AccountYok.TabIndex = 9;
            this.AccountYok.TabStop = true;
            this.AccountYok.Text = "Do not have account";
            this.AccountYok.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AccountYok.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AccountYok_LinkClicked);
            // 
            // ForgotPass
            // 
            this.ForgotPass.AutoSize = true;
            this.ForgotPass.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ForgotPass.Location = new System.Drawing.Point(6, 400);
            this.ForgotPass.Name = "ForgotPass";
            this.ForgotPass.Size = new System.Drawing.Size(86, 13);
            this.ForgotPass.TabIndex = 8;
            this.ForgotPass.TabStop = true;
            this.ForgotPass.Text = "Forgot Password";
            this.ForgotPass.VisitedLinkColor = System.Drawing.Color.Black;
            this.ForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPass_LinkClicked);
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.LogInBtn.FlatAppearance.BorderSize = 0;
            this.LogInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.LogInBtn.Location = new System.Drawing.Point(91, 308);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(93, 35);
            this.LogInBtn.TabIndex = 7;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PassLabel.Location = new System.Drawing.Point(29, 227);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(61, 15);
            this.PassLabel.TabIndex = 6;
            this.PassLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UsernameLabel.Location = new System.Drawing.Point(29, 134);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(62, 15);
            this.UsernameLabel.TabIndex = 5;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(32, 256);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(214, 19);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(32, 162);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(214, 19);
            this.UsernameTextBox.TabIndex = 3;
            // 
            // HRPanelPassword
            // 
            this.HRPanelPassword.BackColor = System.Drawing.Color.DimGray;
            this.HRPanelPassword.Location = new System.Drawing.Point(32, 281);
            this.HRPanelPassword.Name = "HRPanelPassword";
            this.HRPanelPassword.Size = new System.Drawing.Size(215, 1);
            this.HRPanelPassword.TabIndex = 2;
            // 
            // HRPanelUsername
            // 
            this.HRPanelUsername.BackColor = System.Drawing.Color.DimGray;
            this.HRPanelUsername.Controls.Add(this.panel3);
            this.HRPanelUsername.Location = new System.Drawing.Point(32, 187);
            this.HRPanelUsername.Name = "HRPanelUsername";
            this.HRPanelUsername.Size = new System.Drawing.Size(215, 1);
            this.HRPanelUsername.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 1);
            this.panel3.TabIndex = 2;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.SkyBlue;
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(300, 101);
            this.TitlePanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(55, 34);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(183, 29);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Team Byal Dunav";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::GameLauncher.Properties.Resources.background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 596);
            this.Controls.Add(this.LoginFromPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Byal Dunav Launcher";
            this.LoginFromPanel.ResumeLayout(false);
            this.LoginFromPanel.PerformLayout();
            this.HRPanelUsername.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginFromPanel;
        private System.Windows.Forms.Panel HRPanelPassword;
        private System.Windows.Forms.Panel HRPanelUsername;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.LinkLabel AccountYok;
        private System.Windows.Forms.LinkLabel ForgotPass;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ShortPassLabel;
        private System.Windows.Forms.Label AllReqLabel;
        private System.Windows.Forms.Label LoginFailedLabel;
    }
}

