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
            this.SignIn = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.SignInPanel = new System.Windows.Forms.Panel();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.SignUpLink = new System.Windows.Forms.LinkLabel();
            this.ResetPassLink = new System.Windows.Forms.LinkLabel();
            this.jTextBox1 = new JTextBox.JTextBox();
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
            this.user.Click += new System.EventHandler(this.user_Click);
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
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // SignInPanel
            // 
            this.SignInPanel.Controls.Add(this.ErrorMessage);
            this.SignInPanel.Controls.Add(this.LogInBtn);
            this.SignInPanel.Controls.Add(this.SignUpLink);
            this.SignInPanel.Controls.Add(this.ResetPassLink);
            this.SignInPanel.Controls.Add(this.jTextBox1);
            this.SignInPanel.Controls.Add(this.UserInputUserName);
            this.SignInPanel.Controls.Add(this.Password);
            this.SignInPanel.Controls.Add(this.user);
            this.SignInPanel.Location = new System.Drawing.Point(4, 12);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(338, 458);
            this.SignInPanel.TabIndex = 12;
            this.SignInPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SignInPanel_Paint);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(88, 319);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.ErrorMessage.TabIndex = 17;
            this.ErrorMessage.Click += new System.EventHandler(this.ErrorMessage_Click);
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
            this.SignUpLink.Location = new System.Drawing.Point(99, 388);
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
            // jTextBox1
            // 
            this.jTextBox1.AutoSize = true;
            this.jTextBox1.BorderColor = System.Drawing.Color.Black;
            this.jTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.jTextBox1.Hint = "";
            this.jTextBox1.IsPassword = true;
            this.jTextBox1.Length = 0;
            this.jTextBox1.Location = new System.Drawing.Point(61, 222);
            this.jTextBox1.Name = "jTextBox1";
            this.jTextBox1.OnFocus = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.jTextBox1.OnlyChar = false;
            this.jTextBox1.OnlyNumber = false;
            this.jTextBox1.Size = new System.Drawing.Size(198, 39);
            this.jTextBox1.TabIndex = 13;
            this.jTextBox1.TextValue = "";
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
            this.UserInputUserName.Load += new System.EventHandler(this.UserInputUserName_Load);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.SignIn);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 92);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(341, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SignInPanel);
            this.Name = "Form1";
            this.Text = "Team Byal Dunav Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private JTextBox.JTextBox jTextBox1;
        private System.Windows.Forms.LinkLabel SignUpLink;
        private System.Windows.Forms.LinkLabel ResetPassLink;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Label ErrorMessage;
    }
}

