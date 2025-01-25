namespace Bai2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBoxPhepTinh_TextChanged(object sender, EventArgs e)
        {
            string phepTinh = textBoxPhepTinh.Text;

            if (phepTinh.Length == 0)
            {
                labelKetQua.Text = "0";
                return;
            }

            int operatorIndex = -1;
            for (int i = 0; i < phepTinh.Length; i++)
            {
                if (phepTinh[i] == '+' || phepTinh[i] == '-' || phepTinh[i] == '*' || phepTinh[i] == '/')
                {
                    operatorIndex = i;
                    break;
                }
            }

            if (operatorIndex == -1)
            {
                labelKetQua.Text = "0";
                return;
            }

            string strSoThuNhat = phepTinh.Substring(0, operatorIndex);
            string strSoThuHai = phepTinh.Substring(operatorIndex + 1);

            if (strSoThuNhat.Length == 0 || strSoThuHai.Length == 0)
            {
                labelKetQua.Text = "0";
                return;
            }

            double soThuNhat = double.Parse(strSoThuNhat);
            double soThuHai = double.Parse(strSoThuHai);

            double ketQua = 0;
            if (phepTinh[operatorIndex] == '+')
            {
                ketQua = soThuNhat + soThuHai;
            }
            else if (phepTinh[operatorIndex] == '-')
            {
                ketQua = soThuNhat - soThuHai;
            }
            else if (phepTinh[operatorIndex] == '*')
            {
                ketQua = soThuNhat * soThuHai;
            }
            else if (phepTinh[operatorIndex] == '/')
            {
                ketQua = soThuNhat / soThuHai;
            }

            labelKetQua.Text = ketQua.ToString();


        }
    }
}
