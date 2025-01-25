namespace ExampleWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly List<string> textBoxes = new List<string>();

        private void btnSave_Click(object sender, EventArgs e)
        {
            string textBoxContent = textBox.Text.Trim();

            if (!string.IsNullOrEmpty(textBoxContent))
            {
                textBoxes.Add(textBoxContent);
                UpdateListView();
            }

            textBox.Clear();
        }

        private void UpdateListView()
        {
            // Cập nhật ListView
            listView1.Items.Clear();
            listView1.Items.AddRange(textBoxes.Select(content => new ListViewItem(content)).ToArray());
        }
    }
}
