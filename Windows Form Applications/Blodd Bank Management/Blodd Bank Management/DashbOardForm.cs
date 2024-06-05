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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void addNewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor form = new AddNewDonor();
            form.Show();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDonorDetails updateDonorDetails = new UpdateDonorDetails();
            updateDonorDetails.Show();

        }

        private void allDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllDonorDetails allDonorDetails = new AllDonorDetails();    
            allDonorDetails.Show(); 
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDonorAddress searchDonorAddress = new SearchDonorAddress();
            searchDonorAddress.Show();
        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDonorBloodGroup searchDonorBloodGroup = new SearchDonorBloodGroup();
            searchDonorBloodGroup.Show();
        }

        private void deleteDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDonor deleteDonor = new DeleteDonor();
            deleteDonor.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
