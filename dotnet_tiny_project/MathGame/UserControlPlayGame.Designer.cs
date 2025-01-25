namespace MathGame
{
    partial class UserControlPlayGame
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelLevel = new Label();
            labelQuestion = new Label();
            textBoxAnswer = new TextBox();
            buttonCheckAnswer = new Button();
            buttonNextQuestion = new Button();
            labelCorrectAnswer = new Label();
            labelScore = new Label();
            labelTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelLevel
            // 
            labelLevel.AutoSize = true;
            labelLevel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLevel.Location = new Point(15, 13);
            labelLevel.Name = "labelLevel";
            labelLevel.Size = new Size(143, 32);
            labelLevel.TabIndex = 0;
            labelLevel.Text = "Chế độ chơi";
            // 
            // labelQuestion
            // 
            labelQuestion.AutoSize = true;
            labelQuestion.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuestion.Location = new Point(116, 131);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(205, 65);
            labelQuestion.TabIndex = 1;
            labelQuestion.Text = "1 + 1 = ?";
            // 
            // textBoxAnswer
            // 
            textBoxAnswer.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxAnswer.Location = new Point(448, 131);
            textBoxAnswer.Name = "textBoxAnswer";
            textBoxAnswer.Size = new Size(170, 71);
            textBoxAnswer.TabIndex = 2;
            // 
            // buttonCheckAnswer
            // 
            buttonCheckAnswer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCheckAnswer.Location = new Point(207, 247);
            buttonCheckAnswer.Name = "buttonCheckAnswer";
            buttonCheckAnswer.Size = new Size(350, 68);
            buttonCheckAnswer.TabIndex = 3;
            buttonCheckAnswer.Text = "Kiểm tra đáp án";
            buttonCheckAnswer.UseVisualStyleBackColor = true;
            buttonCheckAnswer.Click += buttonCheckAnswer_Click;
            // 
            // buttonNextQuestion
            // 
            buttonNextQuestion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNextQuestion.Location = new Point(546, 360);
            buttonNextQuestion.Name = "buttonNextQuestion";
            buttonNextQuestion.Size = new Size(194, 50);
            buttonNextQuestion.TabIndex = 4;
            buttonNextQuestion.Text = "Câu hỏi tiếp theo";
            buttonNextQuestion.UseVisualStyleBackColor = true;
            buttonNextQuestion.Click += buttonNextQuestion_Click;
            // 
            // labelCorrectAnswer
            // 
            labelCorrectAnswer.AutoSize = true;
            labelCorrectAnswer.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCorrectAnswer.Location = new Point(640, 134);
            labelCorrectAnswer.Name = "labelCorrectAnswer";
            labelCorrectAnswer.Size = new Size(65, 65);
            labelCorrectAnswer.TabIndex = 5;
            labelCorrectAnswer.Text = "✓";
            // 
            // labelScore
            // 
            labelScore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelScore.Location = new Point(607, 13);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(143, 32);
            labelScore.TabIndex = 6;
            labelScore.Text = "Điểm: 0";
            labelScore.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTime.Location = new Point(344, 13);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(71, 32);
            labelTime.TabIndex = 7;
            labelTime.Text = "00:00";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // UserControlPlayGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelTime);
            Controls.Add(labelScore);
            Controls.Add(labelCorrectAnswer);
            Controls.Add(buttonNextQuestion);
            Controls.Add(buttonCheckAnswer);
            Controls.Add(textBoxAnswer);
            Controls.Add(labelQuestion);
            Controls.Add(labelLevel);
            Name = "UserControlPlayGame";
            Size = new Size(776, 426);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLevel;
        private Label labelQuestion;
        private TextBox textBoxAnswer;
        private Button buttonCheckAnswer;
        private Button buttonNextQuestion;
        private Label labelCorrectAnswer;
        private Label labelScore;
        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
    }
}
