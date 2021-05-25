using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class LoginForm : Form
    {
        public Main mainForm { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            var username = UsernameTextBox.Text;
            var password = PasswordTextBox.Text;
            ErrorMessages(username, password);
        }

        private void CleanErrors()
        {
            AllReqLabel.Text = "";
            ShortPassLabel.Text = "";
            LoginFailedLabel.Text = "";
        }
        private void ErrorMessages(string username, string password)
        {
            if (username.Length == 0 || password.Length == 0)
            {
                CleanErrors();
                AllReqLabel.Text = "All fields are required";
            }
            else if (password.Length < 6)
            {
                CleanErrors();
                ShortPassLabel.Text = "Password must be minumum 6 symbols";
            }
            else
            {
                CleanErrors();
                // Kum Vankata
            }
        }

        private void ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ForgotPass.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=8UZMGKuLfjY");
        }

        private void AccountYok_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountYok.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=YZqF5Uun6AQ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm = new Main();
            mainForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1_Click(this, null);
        }
    }
}

