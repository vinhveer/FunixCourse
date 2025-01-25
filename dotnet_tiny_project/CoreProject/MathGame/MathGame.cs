namespace MathGame
{
    public partial class MathGame : Form
    {
        public UserControlStartGame userControlStartGame = new UserControlStartGame();
        public UserControlPlayGame userControlPlayGame = new UserControlPlayGame();
        public UserControlEndGame userControlEndGame = new UserControlEndGame();
 
        public MathGame()
        {
            InitializeComponent();

            panelLayout.Controls.Add(userControlStartGame);
            panelLayout.ResumeLayout();
        }

        public void GoToStartGame()
        {
            panelLayout.Controls.Clear();
            panelLayout.Controls.Add(userControlStartGame);
            panelLayout.ResumeLayout();
        }

        public void StartGame(string level)
        {
            panelLayout.Controls.Clear();

            userControlPlayGame.Level = level;
            panelLayout.Controls.Add(userControlPlayGame);
            panelLayout.ResumeLayout();
        }

        public void EndGame(int score, string message)
        {
            panelLayout.Controls.Clear();
            userControlEndGame.Score = score;
            userControlEndGame.Message = message;
            panelLayout.Controls.Add(userControlEndGame);
            panelLayout.ResumeLayout();
        }
    }
}
