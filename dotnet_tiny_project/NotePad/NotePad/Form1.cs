namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string fileOpen = "";

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileOpen = openFileDialog.FileName;
                labelOpenFile.Text = fileOpen;
                textBoxFileContent.Text = File.ReadAllText(fileOpen);
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileOpen) || !File.Exists(fileOpen))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                    FileName = fileOpen
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileOpen = saveFileDialog.FileName;
                }
                else
                {
                    return;
                }
            }

            File.WriteAllText(fileOpen, textBoxFileContent.Text);
        }

        private void buttonCloseFile_Click(object sender, EventArgs e)
        {
            fileOpen = "";
            labelOpenFile.Text = "";
            textBoxFileContent.Text = "";
        }
    }
}
