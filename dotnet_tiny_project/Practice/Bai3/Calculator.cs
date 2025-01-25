namespace Bai3
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private double? firstNumber;
        private double? secondNumber;

        private string? operation;

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxOperation.Text += "0";
        }

        private void buttonNumber1_Click(object sender, EventArgs e)
        {
            textBoxOperation.Text += "1";
        }

        private void buttonNumber2_Click(object sender, EventArgs e)
        {
            textBoxOperation.Text += "2";
        }

        private void buttonNumber3_Click(object sender, EventArgs e)
        {
            textBoxOperation.Text += "3";
        }

        private void buttonNumber4_Click(object sender, EventArgs e)
        {
            textBoxOperation.Text += "4";
        }

        private void buttonNumber5_Click(object sender, EventArgs e)
        {
            textBoxOperation.Text += "5";
        }

        private void buttonNumber6_Click(object sender, EventArgs e)
        {
            textBoxOperation.Text += "6";
        }

        private void buttonNumber7_Click(object sender, EventArgs e)
        {
            textBoxOperation.Text += "7";
        }

        private void buttonNumber8_Click(object sender, EventArgs e)
        {
            textBoxOperation.Text += "8";
        }

        private void buttonNumber9_Click(object sender, EventArgs e)
        {
            textBoxOperation.Text += "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {

        }
    }
}
