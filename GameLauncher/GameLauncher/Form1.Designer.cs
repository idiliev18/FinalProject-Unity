namespace GameLauncher
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
            this.TeamName = new System.Windows.Forms.Label();
            this.LogInTitle = new System.Windows.Forms.Label();
            this.SignIn = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.UserInputUsername = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.UserInputPassword = new System.Windows.Forms.TextBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.SignUpLink = new System.Windows.Forms.LinkLabel();
            this.AccountYok = new System.Windows.Forms.Label();
            this.ForgotPass = new System.Windows.Forms.Label();
            this.ResetPassLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamName.Location = new System.Drawing.Point(81, 78);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(133, 13);
            this.TeamName.TabIndex = 0;
            this.TeamName.Text = "By Team Byal Dunav";
            this.TeamName.Click += new System.EventHandler(this.TeamName_Click);
            // 
            // LogInTitle
            // 
            this.LogInTitle.AutoSize = true;
            this.LogInTitle.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInTitle.Location = new System.Drawing.Point(32, 25);
            this.LogInTitle.Name = "LogInTitle";
            this.LogInTitle.Size = new System.Drawing.Size(223, 33);
            this.LogInTitle.TabIndex = 1;
            this.LogInTitle.Text = "Arduino Games";
            this.LogInTitle.Click += new System.EventHandler(this.LogInTitle_Click);
            // 
            // SignIn
            // 
            this.SignIn.AutoSize = true;
            this.SignIn.Font = new System.Drawing.Font("MS PGothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.Location = new System.Drawing.Point(311, 115);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(156, 48);
            this.SignIn.TabIndex = 2;
            this.SignIn.Text = "Sign In";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(224, 209);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(55, 13);
            this.user.TabIndex = 3;
            this.user.Text = "Username";
            // 
            // UserInputUsername
            // 
            this.UserInputUsername.Location = new System.Drawing.Point(285, 206);
            this.UserInputUsername.Name = "UserInputUsername";
            this.UserInputUsername.Size = new System.Drawing.Size(173, 20);
            this.UserInputUsername.TabIndex = 4;
            this.UserInputUsername.TextChanged += new System.EventHandler(this.UserInputUsername_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(224, 258);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            // 
            // UserInputPassword
            // 
            this.UserInputPassword.Location = new System.Drawing.Point(291, 251);
            this.UserInputPassword.Name = "UserInputPassword";
            this.UserInputPassword.Size = new System.Drawing.Size(166, 20);
            this.UserInputPassword.TabIndex = 6;
            this.UserInputPassword.UseSystemPasswordChar = true;
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(319, 277);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(100, 42);
            this.SignInButton.TabIndex = 7;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            // 
            // SignUpLink
            // 
            this.SignUpLink.AutoSize = true;
            this.SignUpLink.Location = new System.Drawing.Point(412, 378);
            this.SignUpLink.Name = "SignUpLink";
            this.SignUpLink.Size = new System.Drawing.Size(45, 13);
            this.SignUpLink.TabIndex = 8;
            this.SignUpLink.TabStop = true;
            this.SignUpLink.Text = "Sign Up";
            this.SignUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLink_LinkClicked);
            // 
            // AccountYok
            // 
            this.AccountYok.AutoSize = true;
            this.AccountYok.Location = new System.Drawing.Point(301, 378);
            this.AccountYok.Name = "AccountYok";
            this.AccountYok.Size = new System.Drawing.Size(114, 13);
            this.AccountYok.TabIndex = 9;
            this.AccountYok.Text = "Do not have account?";
            // 
            // ForgotPass
            // 
            this.ForgotPass.AutoSize = true;
            this.ForgotPass.Location = new System.Drawing.Point(301, 354);
            this.ForgotPass.Name = "ForgotPass";
            this.ForgotPass.Size = new System.Drawing.Size(134, 13);
            this.ForgotPass.TabIndex = 10;
            this.ForgotPass.Text = "Forgot Password? Reset it ";
            // 
            // ResetPassLink
            // 
            this.ResetPassLink.AutoSize = true;
            this.ResetPassLink.Location = new System.Drawing.Point(429, 354);
            this.ResetPassLink.Name = "ResetPassLink";
            this.ResetPassLink.Size = new System.Drawing.Size(28, 13);
            this.ResetPassLink.TabIndex = 11;
            this.ResetPassLink.TabStop = true;
            this.ResetPassLink.Text = "here";
            this.ResetPassLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ResetPassLink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetPassLink);
            this.Controls.Add(this.ForgotPass);
            this.Controls.Add(this.AccountYok);
            this.Controls.Add(this.SignUpLink);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.UserInputPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserInputUsername);
            this.Controls.Add(this.user);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.LogInTitle);
            this.Controls.Add(this.TeamName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TeamName;
        private System.Windows.Forms.Label LogInTitle;
        private System.Windows.Forms.Label SignIn;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox UserInputUsername;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox UserInputPassword;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.LinkLabel SignUpLink;
        private System.Windows.Forms.Label AccountYok;
        private System.Windows.Forms.Label ForgotPass;
        private System.Windows.Forms.LinkLabel ResetPassLink;
    }
}

