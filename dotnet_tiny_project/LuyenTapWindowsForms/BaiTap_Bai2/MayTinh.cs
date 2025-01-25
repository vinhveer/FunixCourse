namespace BaiTap_Bai2
{
    public partial class MayTinh : Form
    {
        public MayTinh()
        {
            InitializeComponent();
        }

        private void textBoxNhapBieuThuc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string textBoxNhapBieuThuc_Text = textBoxNhapBieuThuc.Text;

                if (textBoxNhapBieuThuc_Text.Length == 0)
                {
                    textBoxKetQua.Text = "";
                    return;
                }

                // find the last operator
                int lastOperatorIndex = -1;
                for (int i = textBoxNhapBieuThuc_Text.Length - 1; i >= 0; i--)
                {
                    if (textBoxNhapBieuThuc_Text[i] == '+' || textBoxNhapBieuThuc_Text[i] == '-' || textBoxNhapBieuThuc_Text[i] == '*' || textBoxNhapBieuThuc_Text[i] == '/')
                    {
                        lastOperatorIndex = i;
                        break;
                    }
                }

                // Caculate the result
                if (lastOperatorIndex == -1)
                {
                    textBoxKetQua.Text = textBoxNhapBieuThuc_Text;
                    return;
                }

                string firstNumber = textBoxNhapBieuThuc_Text.Substring(0, lastOperatorIndex);
                string secondNumber = textBoxNhapBieuThuc_Text.Substring(lastOperatorIndex + 1);

                double firstNumberValue = double.Parse(firstNumber);
                double secondNumberValue = double.Parse(secondNumber);

                double result = 0;
                switch (textBoxNhapBieuThuc_Text[lastOperatorIndex])
                {
                    case '+':
                        result = firstNumberValue + secondNumberValue;
                        break;
                    case '-':
                        result = firstNumberValue - secondNumberValue;
                        break;
                    case '*':
                        result = firstNumberValue * secondNumberValue;
                        break;
                    case '/':
                        result = firstNumberValue / secondNumberValue;
                        break;
                }

                textBoxKetQua.Text = result.ToString();
            }
            catch (Exception)
            {
                textBoxKetQua.Text = "";
            }
        }
    }
}
