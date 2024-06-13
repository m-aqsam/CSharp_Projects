// Blodd_Bank_Management/AddNewDonor.cs
using BloodBank.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Blodd_Bank_Management
{
    public partial class AddNewDonor : Form
    {
        private readonly BloodBankService _bloodBankService;

        public AddNewDonor()
        {
            InitializeComponent();
            _bloodBankService = new BloodBankService();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            string query = "select max(did) from newdonor";
            DataSet ds = _bloodBankService.GetData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            labelNewID.Text = (count + 1).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtDOB.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtBloodGroup.Text != "" && txtCity.Text != "" && txtAdresess.Text != "")
            {
                string dname = txtName.Text;
                string fname = txtFather.Text;
                string mname = txtMother.Text;
                string dob = txtDOB.Text;
                long mobile = long.Parse(txtMobile.Text);
                string gender = txtGender.Text;
                string email = txtEmail.Text;
                string bloodgroup = txtBloodGroup.Text;
                string city = txtCity.Text;
                string daddress = txtAdresess.Text;

                string query = $"insert into newdonor (dname, fname, mname, dob, mobile, gender, email, bloodgroup, city, daddress) VALUES ('{dname}', '{fname}', '{mname}', '{dob}', {mobile}, '{gender}', '{email}', '{bloodgroup}', '{city}', '{daddress}')";
                _bloodBankService.SetData(query);
                // Reset Method Call

                btnReset_Click(sender, e);


            }
            else
            {
                MessageBox.Show("Fill all Fields in the Form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtDOB.ResetText();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtBloodGroup.SelectedIndex = -1;
            txtCity.Clear();
            txtAdresess.Clear();
        }
    }
}
