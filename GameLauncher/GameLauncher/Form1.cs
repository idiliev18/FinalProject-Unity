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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VisitLinkSignUp()
        {

            SignUpLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=YZqF5Uun6AQ");
        }

        private void VisitLinkForgotPass()
        {
            ResetPassLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=8UZMGKuLfjY");
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            var username = UserInputUserName.TextValue;
            var password = UserInputPass.TextValue;
            ErrorMessages(username, password);
        }

        private void ResetPassLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLinkForgotPass();
        }

        private void SignUpLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLinkSignUp();
        }

        private bool IsPasswordValid(string pass)
        {

            if (pass.Length < 6)
            {
                return false;
            }
            return true;

        }

        private bool IsUsernameValid(string user)
        {

            if (user.Length > 0)
            {
                return true ;
            }
            return false;

        }

        private void ErrorMessages(string user, string pass)
        {
            if (IsPasswordValid(pass) && IsUsernameValid(user))
            {
                ErrorMessage.Text = "";
                AllFields.Text = "";
                // Kum Vankata
            }
            else if(!IsPasswordValid(pass) && IsUsernameValid(user))
            {
                AllFields.Text = "";
                ErrorMessage.Text = "Password should be minimum 6 symbols! ";
            }
            else 
            {
                AllFields.Text = "All fields are required!";
            }
        }
    }
}
