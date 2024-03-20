using System.ComponentModel.DataAnnotations;

namespace ImageSlider
{
    public partial class Form1 : Form
    {

        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 15)
            {
                pictureBox1.Image = imageList1.Images[count];
                count++;

            }
            else
            {
                count = 0;
            }
        }
    }
}
