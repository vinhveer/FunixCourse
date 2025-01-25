namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Delete the selected row
            dataGridView1.Rows.RemoveAt(e.RowIndex);
        }
    }
}