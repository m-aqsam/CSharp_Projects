﻿using BloodBank.BLL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Blodd_Bank_Management
{
    public partial class SearchDonorBloodGroup : Form
    {
        private readonly BloodBankService _bloodBankService;

        public SearchDonorBloodGroup()
        {
            InitializeComponent();
            _bloodBankService = new BloodBankService();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchDonorBloodGroup_Load(object sender, EventArgs e)
        {
            String query = "select * from newdonor";
            DataSet ds = _bloodBankService.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtBloodGroup_TextChanged(object sender, EventArgs e)
        {
            if (txtBloodGroup.Text != "")
            {
                String query = "select * from newdonor where bloodgroup like '" + txtBloodGroup.Text + "%' ";
                DataSet ds = _bloodBankService.GetData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                String query = "select * from newdonor";
                DataSet ds = _bloodBankService.GetData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
