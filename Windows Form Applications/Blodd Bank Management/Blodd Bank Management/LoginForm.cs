using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blodd_Bank_Management
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            loginButton.Enabled = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameText.Text=="aqsam" && passwordText.Text=="12345")
            {
                DashboardForm dashbOardForm = new DashboardForm();
                dashbOardForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter Correct Username and Password.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnHideShow.Text == "Show")
            {
                btnHideShow.Text = "Hide";
                passwordText.PasswordChar = '\0';
            }
            else
            {
                btnHideShow.Text = "Show";
                passwordText.PasswordChar= '*';
            }
        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked==true)
            {
                loginButton.Enabled = true;
            }
            else
            {
                loginButton.Enabled = false;
            }
        }

        
    }
}
