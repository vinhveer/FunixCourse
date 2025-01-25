namespace PracticeWindowsForm2
{
    public partial class Practice : Form
    {
        UserControlStart userControlStart = new UserControlStart();
        UserControlEnd userControlEnd = new UserControlEnd();

        public Practice()
        {
            InitializeComponent();

            panelLayout.Controls.Add(userControlStart);
        }

        public void GotoUserControlEnd()
        {
            panelLayout.Controls.Clear();
            panelLayout.Controls.Add(userControlEnd);
        }

        public void GotoUserControlStart()
        {
            panelLayout.Controls.Clear();
            panelLayout.Controls.Add(userControlStart);
        }
    }
}
