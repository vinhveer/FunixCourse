namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHienThiLoiChao_Click(object sender, EventArgs e)
        {
            string tenNguoiDung = textBoxInputName.Text;
            MessageBox.Show("Xin chào " + tenNguoiDung);
        }
    }
}
