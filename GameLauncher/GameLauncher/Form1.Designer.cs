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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SignIn = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.SignInPanel = new System.Windows.Forms.Panel();
            this.AllFields = new System.Windows.Forms.Label();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.SignUpLink = new System.Windows.Forms.LinkLabel();
            this.ResetPassLink = new System.Windows.Forms.LinkLabel();
            this.UserInputPass = new JTextBox.JTextBox();
            this.UserInputUserName = new JTextBox.JTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SignInPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignIn
            // 
            this.SignIn.AutoSize = true;
            this.SignIn.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SignIn.Location = new System.Drawing.Point(95, 26);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(144, 42);
            this.SignIn.TabIndex = 2;
            this.SignIn.Text = "Sign In";
            this.SignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.user.Location = new System.Drawing.Point(69, 112);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(103, 18);
            this.user.TabIndex = 3;
            this.user.Text = "Username: ";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Password.Location = new System.Drawing.Point(69, 201);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(92, 18);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password:";
            // 
            // SignInPanel
            // 
            this.SignInPanel.BackColor = System.Drawing.Color.White;
            this.SignInPanel.Controls.Add(this.panel2);
            this.SignInPanel.Controls.Add(this.AllFields);
            this.SignInPanel.Controls.Add(this.ErrorMessage);
            this.SignInPanel.Controls.Add(this.LogInBtn);
            this.SignInPanel.Controls.Add(this.SignUpLink);
            this.SignInPanel.Controls.Add(this.ResetPassLink);
            this.SignInPanel.Controls.Add(this.UserInputPass);
            this.SignInPanel.Controls.Add(this.UserInputUserName);
            this.SignInPanel.Controls.Add(this.Password);
            this.SignInPanel.Controls.Add(this.user);
            this.SignInPanel.Location = new System.Drawing.Point(326, 64);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(338, 458);
            this.SignInPanel.TabIndex = 12;
            // 
            // AllFields
            // 
            this.AllFields.AutoSize = true;
            this.AllFields.ForeColor = System.Drawing.Color.Red;
            this.AllFields.Location = new System.Drawing.Point(110, 319);
            this.AllFields.Name = "AllFields";
            this.AllFields.Size = new System.Drawing.Size(0, 13);
            this.AllFields.TabIndex = 19;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(69, 319);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.ErrorMessage.TabIndex = 17;
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.White;
            this.LogInBtn.ForeColor = System.Drawing.Color.Black;
            this.LogInBtn.Location = new System.Drawing.Point(119, 280);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(75, 23);
            this.LogInBtn.TabIndex = 16;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // SignUpLink
            // 
            this.SignUpLink.AutoSize = true;
            this.SignUpLink.LinkColor = System.Drawing.Color.Black;
            this.SignUpLink.Location = new System.Drawing.Point(98, 388);
            this.SignUpLink.Name = "SignUpLink";
            this.SignUpLink.Size = new System.Drawing.Size(129, 13);
            this.SignUpLink.TabIndex = 15;
            this.SignUpLink.TabStop = true;
            this.SignUpLink.Text = "Do not have an account?";
            this.SignUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLink_LinkClicked_1);
            // 
            // ResetPassLink
            // 
            this.ResetPassLink.AutoSize = true;
            this.ResetPassLink.LinkColor = System.Drawing.Color.Black;
            this.ResetPassLink.Location = new System.Drawing.Point(116, 365);
            this.ResetPassLink.Name = "ResetPassLink";
            this.ResetPassLink.Size = new System.Drawing.Size(86, 13);
            this.ResetPassLink.TabIndex = 14;
            this.ResetPassLink.TabStop = true;
            this.ResetPassLink.Text = "Forgot Password";
            this.ResetPassLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ResetPassLink_LinkClicked_1);
            // 
            // UserInputPass
            // 
            this.UserInputPass.AutoSize = true;
            this.UserInputPass.BorderColor = System.Drawing.Color.Black;
            this.UserInputPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserInputPass.Hint = "";
            this.UserInputPass.IsPassword = true;
            this.UserInputPass.Length = 0;
            this.UserInputPass.Location = new System.Drawing.Point(61, 222);
            this.UserInputPass.Name = "UserInputPass";
            this.UserInputPass.OnFocus = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserInputPass.OnlyChar = false;
            this.UserInputPass.OnlyNumber = false;
            this.UserInputPass.Size = new System.Drawing.Size(198, 39);
            this.UserInputPass.TabIndex = 13;
            this.UserInputPass.TextValue = "";
            // 
            // UserInputUserName
            // 
            this.UserInputUserName.AutoSize = true;
            this.UserInputUserName.BorderColor = System.Drawing.Color.Black;
            this.UserInputUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserInputUserName.Hint = "";
            this.UserInputUserName.IsPassword = false;
            this.UserInputUserName.Length = 0;
            this.UserInputUserName.Location = new System.Drawing.Point(61, 133);
            this.UserInputUserName.Name = "UserInputUserName";
            this.UserInputUserName.OnFocus = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserInputUserName.OnlyChar = false;
            this.UserInputUserName.OnlyNumber = false;
            this.UserInputUserName.Size = new System.Drawing.Size(200, 39);
            this.UserInputUserName.TabIndex = 12;
            this.UserInputUserName.TextValue = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.SignIn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 92);
            this.panel2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 596);
            this.Controls.Add(this.SignInPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Team Byal Dunav Launcher";
            this.SignInPanel.ResumeLayout(false);
            this.SignInPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label SignIn;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Panel SignInPanel;
        private System.Windows.Forms.Panel panel2;
        private JTextBox.JTextBox UserInputUserName;
        private JTextBox.JTextBox UserInputPass;
        private System.Windows.Forms.LinkLabel SignUpLink;
        private System.Windows.Forms.LinkLabel ResetPassLink;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.Label AllFields;
    }
}

