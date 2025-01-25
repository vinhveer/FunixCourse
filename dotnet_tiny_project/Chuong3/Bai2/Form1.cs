namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(textBoxNumber1.Text);
            int number2 = int.Parse(textBoxNumber2.Text);

            int sum = number1 + number2;

            // Show the result
            labelResult.Text = $"Kết quả: {sum}";
        }
    }
}
