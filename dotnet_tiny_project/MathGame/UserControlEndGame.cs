namespace MathGame
{
    public partial class UserControlEndGame : UserControl
    {
        private string message = "Bạn đã hoàn thành game";
        private int score = 0;

        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                labelSuccess.Text = message;
            }
        }

        public void SetScore(int score)
        {
            this.score = score;
            labelScore.Text = score.ToString();
        }

        public UserControlEndGame()
        {
            InitializeComponent();
        }

        private void buttonReplay_Click(object sender, EventArgs e)
        {
            if (ParentForm is MathGame mathGame)
            {
                mathGame.ReplayGame();
            }
        }
    }
}
