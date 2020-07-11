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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TeamName_Click(object sender, EventArgs e)
        {

        }

        private void LogInTitle_Click(object sender, EventArgs e)
        {

        }

        private void UserInputUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void VisitLinkSignUp()
        {

            SignUpLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=YZqF5Uun6AQ");
        }

        private void  VisitLinkForgotPass()
        {
            ResetPassLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=8UZMGKuLfjY");
        }


        private void UserInputUserName_Load(object sender, EventArgs e)
        {

        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {

        }


        private void SignInPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ResetPassLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLinkForgotPass();
        }

        private void SignUpLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLinkSignUp();
        }
    }
}
