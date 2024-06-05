namespace Blodd_Bank_Management
{
    partial class SearchDonorBloodGroup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDonorBloodGroup));
            this.labelSearchDonorDetails = new System.Windows.Forms.Label();
            this.kryptonSeparator1 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.txtBloodGroup = new System.Windows.Forms.TextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kryptonSeparator2 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.btnPrint = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearchDonorDetails
            // 
            this.labelSearchDonorDetails.AutoSize = true;
            this.labelSearchDonorDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchDonorDetails.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchDonorDetails.Location = new System.Drawing.Point(85, 6);
            this.labelSearchDonorDetails.Name = "labelSearchDonorDetails";
            this.labelSearchDonorDetails.Size = new System.Drawing.Size(550, 38);
            this.labelSearchDonorDetails.TabIndex = 31;
            this.labelSearchDonorDetails.Text = "Search Donor Details (Blood Group)\r\n";
            // 
            // kryptonSeparator1
            // 
            this.kryptonSeparator1.Location = new System.Drawing.Point(0, 53);
            this.kryptonSeparator1.Name = "kryptonSeparator1";
            this.kryptonSeparator1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.kryptonSeparator1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonSeparator1.Size = new System.Drawing.Size(720, 5);
            this.kryptonSeparator1.TabIndex = 32;
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodGroup.Location = new System.Drawing.Point(330, 70);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(199, 27);
            this.txtBloodGroup.TabIndex = 35;
            this.txtBloodGroup.TextChanged += new System.EventHandler(this.txtBloodGroup_TextChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.AutoSize = false;
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(192, 64);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(130, 38);
            this.kryptonLabel1.TabIndex = 34;
            this.kryptonLabel1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonLabel1.Values.Image")));
            this.kryptonLabel1.Values.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(707, 346);
            this.dataGridView1.TabIndex = 36;
            // 
            // kryptonSeparator2
            // 
            this.kryptonSeparator2.Location = new System.Drawing.Point(0, 473);
            this.kryptonSeparator2.Name = "kryptonSeparator2";
            this.kryptonSeparator2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.kryptonSeparator2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonSeparator2.Size = new System.Drawing.Size(720, 5);
            this.kryptonSeparator2.TabIndex = 37;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(92, 485);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnPrint.Size = new System.Drawing.Size(101, 37);
            this.btnPrint.TabIndex = 57;
            this.btnPrint.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Values.Image")));
            this.btnPrint.Values.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(527, 485);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(101, 37);
            this.kryptonButton1.TabIndex = 58;
            this.kryptonButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.Values.Image")));
            this.kryptonButton1.Values.Text = "Close";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // SearchDonorBloodGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 533);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.kryptonSeparator2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBloodGroup);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonSeparator1);
            this.Controls.Add(this.labelSearchDonorDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchDonorBloodGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchDonorBloodGroup";
            this.Load += new System.EventHandler(this.SearchDonorBloodGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearchDonorDetails;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private System.Windows.Forms.TextBox txtBloodGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPrint;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}