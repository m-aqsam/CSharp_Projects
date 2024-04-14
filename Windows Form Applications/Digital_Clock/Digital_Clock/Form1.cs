namespace Digital_Clock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {

            clockTimer.Start();

        }

        private void clock_Timer(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void change_Color(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            clock.ForeColor = button.BackColor;

        }
    }
}
