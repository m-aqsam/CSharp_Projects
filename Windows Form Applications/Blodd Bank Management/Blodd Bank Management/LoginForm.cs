using BloodBank.BLL;
using System;
using System.Windows.Forms;

namespace Blodd_Bank_Management
{
    public partial class LoginForm : Form
    {
        private readonly BloodBankService _service;

        public LoginForm()
        {
            InitializeComponent();
            _service = new BloodBankService();
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
            string username = usernameText.Text;
            string password = passwordText.Text;

            if (_service.ValidateUser(username, password))
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
                passwordText.PasswordChar = '*';
            }
        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            loginButton.Enabled = checkBox.Checked;
        }
    }
}
