using System.Diagnostics;

namespace MathGame
{
    public partial class MathGame : Form
    {
        private UserControlStartGame? userControlStartGame;
        private UserControlPlayGame? userControlPlayGame;
        private UserControlEndGame? userControlEndGame;

        public MathGame()
        {
            InitializeComponent();

            // Add the user controls to the form
            userControlStartGame = new UserControlStartGame();
            panelLayout.Controls.Add(userControlStartGame);
        }

        public void ReplayGame()
        {
            // Remove the end game user control
            panelLayout.Controls.Remove(userControlEndGame);

            // Remove object userControlPlayGame
            userControlPlayGame = new UserControlPlayGame();

            // Add the start game user control
            userControlStartGame = new UserControlStartGame();
            panelLayout.Controls.Add(userControlStartGame);
        }

        public void StartGame(string level)
        {
            panelLayout.Controls.Remove(userControlStartGame);

            userControlPlayGame = new UserControlPlayGame();
            userControlPlayGame.level = level; // Gán giá trị level đúng cách
            userControlPlayGame.InitializeGame();

            panelLayout.Controls.Add(userControlPlayGame);
        }

        public void EndGame(string message, int score)
        {
            // Remove the play game user control
            panelLayout.Controls.Remove(userControlPlayGame);
            
            Debug.WriteLine("EndGame: " + message);

            userControlEndGame = new UserControlEndGame();
            userControlEndGame.Message = message;
            userControlEndGame.SetScore(score);
            panelLayout.Controls.Add(userControlEndGame);
        }
    }
}
