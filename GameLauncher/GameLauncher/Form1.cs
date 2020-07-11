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

        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLinkSignUp();
        }

        private void ResetPassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLinkForgotPass();
        }

       
    }
}
