namespace MathGame
{
    public partial class UserControlEndGame : UserControl
    {
        public int Score { get; set; }
        public string? Message { get; set; }

        public UserControlEndGame()
        {
            InitializeComponent();

            labelSuccess.Text = Message;
            labelScore.Text = $"{Score}";
        }

        private void buttonRePlay_Click(object sender, EventArgs e)
        {
            if (ParentForm is MathGame mathGame)
            {
                mathGame.GoToStartGame();
            }
            else
            {
                MessageBox.Show("ParentForm không hợp lệ hoặc không phải là MathGame!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
