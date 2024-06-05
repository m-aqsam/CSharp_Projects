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
    public partial class AddNewDonor : Form
    {
        Functions fn = new Functions();
        public AddNewDonor()
        {
            InitializeComponent();
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            String query = "select max(did) from newdonor";
            DataSet ds = fn.getData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            labelNewID.Text = (count+1).ToString();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text!="" && txtFather.Text!="" && txtMother.Text!="" && txtDOB.Text!="" && txtMobile.Text!="" && txtGender.Text!="" && txtEmail.Text!="" && txtBloodGroup.Text!="" && txtCity.Text!="" && txtAdresess.Text!="")
            {

                String dname = txtName.Text;
                String fname = txtFather.Text;
                String mname = txtMother.Text;
                String dob = txtDOB.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String bloodgroup= txtBloodGroup.Text;
                String city = txtCity.Text; 
                String daddress = txtAdresess.Text;

                String query = "insert into newdonor (dname,fname,mname,dob,mobile,gender,email,bloodgroup,city,daddress) VALUES ('" + dname + "', '" + fname + "', '" + mname + "', '" + dob + "', " + mobile + ", '" + gender + "', '" + email + "', '" + bloodgroup + "', '" + city + "', '" + daddress + "')";
                fn.setData(query);




            }
            else
            {
                MessageBox.Show("Fill all Fields in the Form","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
