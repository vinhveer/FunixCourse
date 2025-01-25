namespace BaiTap_Bai1
{
    public partial class HienThiLoiChao : Form
    {
        public HienThiLoiChao()
        {
            InitializeComponent();
        }

        private void buttonHelloMessageBox_Click(object sender, EventArgs e)
        {
            string hoTen = textBoxNhapHoTen.Text;

            MessageBox.Show("Xin chào " + hoTen);
        }

        private void buttonHelloLabel_Click(object sender, EventArgs e)
        {
            string hoTen = textBoxNhapHoTen.Text;
            labelHello.Text = "Xin chào " + hoTen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hoTen = textBoxNhapHoTen.Text;
            textBoxHello.Text = "Xin chào " + hoTen;
        }

        private void textBoxNhapHoTen_TextChanged(object sender, EventArgs e)
        {
            string hoTen = textBoxNhapHoTen.Text;
            labelHello.Text = "Xin chào " + hoTen;
        }
    }
}
