namespace Calculator
{
    public partial class Calculator : Form
    {

        int value1;
        int value2;
        int value3;
        string history;
        double result = 0;
        string operatorSign = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox.Text = textBox.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            value1 = Convert.ToInt32(textBox.Text);
            label1.Text = value1.ToString();



            operatorSign = button.Text;
            label2.Text = operatorSign;

            textBox.Text = "";


        }

        private void equal_operator(object sender, EventArgs e)
        {

            value2 = Convert.ToInt32(textBox.Text);
            label3.Text = textBox.Text;



            switch (operatorSign)
            {
                case "+":
                    {
                        value3 = value1 + value2;
                        textBox.Text = value3.ToString();
                    }
                    break;

                case "-":
                    {
                        value3 = value1 - value2;
                        textBox.Text = value3.ToString();
                    }
                    break;

                case "*":
                    {
                        value3 = value1 * value2;
                        textBox.Text = value3.ToString();
                    }
                    break;

                case "/":
                    {
                        value3 = value1 / value2;
                        textBox.Text = value3.ToString();
                    }
                    break;

                default:
                    break;



            }






        }

        private void clear_click(object sender, EventArgs e)
        {
            labelh.Text = label1.Text + label2.Text + label3.Text + " = " + textBox.Text;
            textBox.Text = "";

        }

        private void CE_click(object sender, EventArgs e)
        {
            labelh.Text = label1.Text + label2.Text + label3.Text + " = " + textBox.Text;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            textBox.Text = "";


        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}


 
