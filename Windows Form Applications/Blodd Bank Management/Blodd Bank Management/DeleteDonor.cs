using BloodBank.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Blodd_Bank_Management
{
    public partial class DeleteDonor : Form
    {
        private readonly BloodBankService _bloodBankService;

        public DeleteDonor()
        {
            InitializeComponent();
            _bloodBankService = new BloodBankService();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDonorId.Text))
            {
                String query = "select * from newdonor where did = " + txtDonorId.Text + "";
                DataSet ds = _bloodBankService.GetData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0]["dname"].ToString();
                    txtFather.Text = ds.Tables[0].Rows[0]["fname"].ToString();
                    txtMother.Text = ds.Tables[0].Rows[0]["mname"].ToString();
                    txtDOB.Text = ds.Tables[0].Rows[0]["dob"].ToString();
                    txtMobile.Text = ds.Tables[0].Rows[0]["mobile"].ToString();
                    txtGender.Text = ds.Tables[0].Rows[0]["gender"].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                    txtBloodGroup.Text = ds.Tables[0].Rows[0]["bloodgroup"].ToString();
                    txtCity.Text = ds.Tables[0].Rows[0]["city"].ToString();
                    txtAdresess.Text = ds.Tables[0].Rows[0]["daddress"].ToString();
                }

                else
                {
                    MessageBox.Show("No Record Found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDonorId.Clear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Donor ?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                String query = "delete from newdonor where did = " + txtDonorId.Text + "";
                _bloodBankService.SetData(query);
                txtDonorId.Clear();
            }
        }

        private void txtDonorId_TextChanged(object sender, EventArgs e)
        {
            if (txtDonorId.Text == "")
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDonorId.Clear();
        }
    }
}
