namespace Bai1
{
    public partial class XinChao : Form
    {
        public XinChao()
        {
            InitializeComponent();
        }

        private void buttonMessageBox_Click(object sender, EventArgs e)
        {
            string hoTen = textBoxHoTen.Text;
            MessageBox.Show("Xin chào " + hoTen);
        }

        private void buttonLabel_Click(object sender, EventArgs e)
        {
            string hoTen = textBoxHoTen.Text;
            labelXinChao.Text = "Xin chào " + hoTen;
        }

        private void buttonTextBox_Click(object sender, EventArgs e)
        {
            string hoTen = textBoxHoTen.Text;
            textBoxXinChao.Text = "Xin chào " + hoTen;
        }

        private void textBoxHoTen_TextChanged(object sender, EventArgs e)
        {
            string hoTen = textBoxHoTen.Text;
            labelXinChao.Text = "Xin chào " + hoTen;
        }
    }
}
