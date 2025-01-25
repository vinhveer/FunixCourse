namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCong_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(textBoxNumber1.Text);
            double number2 = double.Parse(textBoxNumber2.Text);

            double cong = number1 + number2;

            // Show the result
            textBoxResult.Text = cong.ToString();
        }

        private void buttonTru_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(textBoxNumber1.Text);
            double number2 = double.Parse(textBoxNumber2.Text);

            double tru = number1 - number2;

            // Show the result
            textBoxResult.Text = tru.ToString();
        }

        private void buttonNhan_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(textBoxNumber1.Text);
            double number2 = double.Parse(textBoxNumber2.Text);

            double nhan = number1 * number2;

            // Show the result
            textBoxResult.Text = nhan.ToString();
        }

        private void buttonChia_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(textBoxNumber1.Text);
            double number2 = double.Parse(textBoxNumber2.Text);

            double chia = number1 / number2;

            // Show the result
            textBoxResult.Text = chia.ToString();
        }
    }
}
