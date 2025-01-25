using System.Diagnostics;

namespace MathGame
{
    public partial class UserControlPlayGame : UserControl
    {
        public string? level { get; set; }

        private Stopwatch stopwatch;

        private int startRandomNumber = 0;
        private int endRandomNumber = 0;

        private int numberQuestion = 0;
        private int minutesLimit = 0;

        private int number1 = 0;
        private int number2 = 0;

        private int score = 0;

        public UserControlPlayGame()
        {
            InitializeComponent();

            stopwatch = new Stopwatch();

            stopwatch.Start();

            timer1.Interval = 1000;
            timer1.Start();
        }

        public void InitializeGame()
        {
            switch (level)
            {
                case "easy":
                    labelLevel.Text = "Chế độ chơi - Dễ";
                    startRandomNumber = 1;
                    endRandomNumber = 10;
                    numberQuestion = 5;
                    minutesLimit = 1;
                    break;
                case "medium":
                    labelLevel.Text = "Chế độ chơi - Trung bình";
                    startRandomNumber = 10;
                    endRandomNumber = 100;
                    numberQuestion = 10;
                    minutesLimit = 5;
                    break;
                case "hard":
                    labelLevel.Text = "Chế độ chơi - Khó";
                    startRandomNumber = 100;
                    endRandomNumber = 1000;
                    numberQuestion = 15;
                    minutesLimit = 10;
                    break;
                default:
                    throw new ArgumentException("Level không hợp lệ");
            }

            CreateQuestion();
            labelCorrectAnswer.Hide();
            buttonNextQuestion.Hide();
        }

        private void CreateQuestion()
        {
            Random random = new Random();
            number1 = random.Next(startRandomNumber, endRandomNumber);
            number2 = random.Next(startRandomNumber, endRandomNumber);
            labelQuestion.Text = number1 + " + " + number2 + " = ?";
        }

        private void buttonCheckAnswer_Click(object sender, EventArgs e)
        {
            int userAnswer;

            // Lặp cho đến khi người dùng nhập một số hợp lệ
            while (true)
            {
                if (!int.TryParse(textBoxAnswer.Text, out userAnswer))
                {
                    MessageBox.Show("Vui lòng nhập một số hợp lệ!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxAnswer.Focus();
                    return; // Thoát ra nếu không muốn tiếp tục xử lý
                }
                else
                {
                    break; // Thoát khỏi vòng lặp khi nhận được giá trị hợp lệ
                }
            }

            // Kiểm tra câu trả lời
            if (number1 + number2 == userAnswer)
            {
                labelCorrectAnswer.Show();
                buttonNextQuestion.Show();
                numberQuestion--;

                score++;
                labelScore.Text = "Điểm: " + score;
            }
            else
            {
                if (ParentForm is MathGame mathGame)
                {
                    mathGame.EndGame("Bạn đã trả lời sai", score);
                }
            }
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            if (numberQuestion != 0)
            {
                CreateQuestion();

                textBoxAnswer.Text = "";

                labelCorrectAnswer.Hide();
                buttonNextQuestion.Hide();
            }
            else
            {
                if (ParentForm is MathGame mathGame)
                {
                    mathGame.EndGame("Bạn đã hoàn thành trò chơi", score);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = stopwatch.Elapsed;
            labelTime.Text = string.Format("{0:mm\\:ss}", elapsed);

            if (elapsed.TotalMinutes >= minutesLimit)
            {
                if (ParentForm is MathGame mathGame)
                {
                    mathGame.EndGame("Hết thời gian", score);
                }
            }
        }
    }
}
