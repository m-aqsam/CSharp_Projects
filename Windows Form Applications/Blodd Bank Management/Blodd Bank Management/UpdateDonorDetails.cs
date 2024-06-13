using BloodBank.BLL;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Blodd_Bank_Management
{
    public partial class UpdateDonorDetails : Form
    {
        private readonly BloodBankService _bloodBankService;

        public UpdateDonorDetails()
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
                Int64 id = Int64.Parse(txtDonorId.Text.ToString());
                String query = "select * from newdonor where did = " + id + " ";
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
                    MessageBox.Show("Id Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            txtDonorId.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDonorId.Text))
            {
                Int64 id = Int64.Parse(txtDonorId.Text.ToString());
                String query = $"UPDATE newdonor SET " +
                    $"dname = '{txtName.Text}', " +
                    $"fname = '{txtFather.Text}', " +
                    $"mname = '{txtMother.Text}', " +
                    $"dob = '{txtDOB.Text}', " +
                    $"mobile = '{txtMobile.Text}', " +
                    $"gender = '{txtGender.Text}', " +
                    $"email = '{txtEmail.Text}', " +
                    $"bloodgroup = '{txtBloodGroup.Text}', " +
                    $"city = '{txtCity.Text}', " +
                    $"daddress = '{txtAdresess.Text}' " +
                    $"WHERE did = {id}";

                _bloodBankService.SetData(query);
                MessageBox.Show("Details updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
