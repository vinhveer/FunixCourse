using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class UserControlPlayGame : UserControl
    {
        private string level = "easy";

        public string Level
        {
            get => level;
            set
            {
                // Kiểm tra và xử lý giá trị hợp lệ.
                if (!string.IsNullOrEmpty(value))
                {
                    level = value;
                }
            }
        }

        private int score = 0;
        private int totalQuestion = 0;
        private int correctQuestion = 0;

        private int startNumRandom = 0;
        private int endNumRandom = 0;

        private int number1 = 0;
        private int number2 = 0;
        private int result = 0;

        public UserControlPlayGame()
        {
            InitializeComponent();

            switch (level)
            {
                case "easy":
                    labelGameMode.Text = "Chế độ chơi - Dễ";
                    startNumRandom = 1;
                    endNumRandom = 10;
                    totalQuestion = 10;
                    break;
                case "medium":
                    labelGameMode.Text = "Chế độ chơi - Trung bình";
                    startNumRandom = 10;
                    endNumRandom = 100;
                    totalQuestion = 15;
                    break;
                case "hard":
                    labelGameMode.Text = "Chế độ chơi - Khó";
                    startNumRandom = 100;
                    endNumRandom = 1000;
                    totalQuestion = 20;
                    break;
            }

            labelCorrect.Hide();

            CreateQuestion(startNumRandom, endNumRandom);
        }

        private void CreateQuestion(int startNumRandom, int endNumRandom)
        {
            Random random = new Random();
            number1 = random.Next(startNumRandom, endNumRandom);
            number2 = random.Next(startNumRandom, endNumRandom);
            result = number1 + number2;
            labelQuestion.Text = number1 + " + " + number2 + " = ?";
            textBoxAnswer.Text = "";
        }

        private void buttonCheckAnswer_Click(object sender, EventArgs e)
        {
            // Kiểm tra câu trả lời
            int result = int.Parse(textBoxAnswer.Text);

            if (result == this.result)
            {
                correctQuestion++;
                labelCorrect.Show();
            }
            else
            {
                if (ParentForm is MathGame mathGame)
                {
                    mathGame.EndGame(score, "Bạn đã trả lời sai");
                }
            }
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            if (totalQuestion > 0)
            {
                totalQuestion--;
                CreateQuestion(startNumRandom, endNumRandom);
                labelCorrect.Hide();
            }
            else
            {
                if (ParentForm is MathGame mathGame)
                {
                    mathGame.EndGame(score, "Bạn đã hoàn thành");
                }
            }
        }
    }
}
