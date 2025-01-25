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
            labelGameMode = new Label();
            labelQuestion = new Label();
            textBoxAnswer = new TextBox();
            buttonCheckAnswer = new Button();
            labelCorrect = new Label();
            buttonNextQuestion = new Button();
            SuspendLayout();
            // 
            // labelGameMode
            // 
            labelGameMode.AutoSize = true;
            labelGameMode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGameMode.Location = new Point(14, 12);
            labelGameMode.Name = "labelGameMode";
            labelGameMode.Size = new Size(197, 32);
            labelGameMode.TabIndex = 0;
            labelGameMode.Text = "Chế độ chơi - Dễ";
            // 
            // labelQuestion
            // 
            labelQuestion.AutoSize = true;
            labelQuestion.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuestion.Location = new Point(130, 184);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(184, 65);
            labelQuestion.TabIndex = 1;
            labelQuestion.Text = "1 + 1 = ";
            // 
            // textBoxAnswer
            // 
            textBoxAnswer.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxAnswer.Location = new Point(458, 181);
            textBoxAnswer.Name = "textBoxAnswer";
            textBoxAnswer.Size = new Size(150, 71);
            textBoxAnswer.TabIndex = 2;
            // 
            // buttonCheckAnswer
            // 
            buttonCheckAnswer.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCheckAnswer.Location = new Point(282, 283);
            buttonCheckAnswer.Name = "buttonCheckAnswer";
            buttonCheckAnswer.Size = new Size(208, 49);
            buttonCheckAnswer.TabIndex = 3;
            buttonCheckAnswer.Text = "Kiểm tra đáp án";
            buttonCheckAnswer.UseVisualStyleBackColor = true;
            buttonCheckAnswer.Click += buttonCheckAnswer_Click;
            // 
            // labelCorrect
            // 
            labelCorrect.AutoSize = true;
            labelCorrect.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCorrect.Location = new Point(614, 181);
            labelCorrect.Name = "labelCorrect";
            labelCorrect.Size = new Size(64, 65);
            labelCorrect.TabIndex = 4;
            labelCorrect.Text = "✓";
            // 
            // buttonNextQuestion
            // 
            buttonNextQuestion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNextQuestion.Location = new Point(522, 377);
            buttonNextQuestion.Name = "buttonNextQuestion";
            buttonNextQuestion.Size = new Size(208, 49);
            buttonNextQuestion.TabIndex = 5;
            buttonNextQuestion.Text = "Câu tiếp theo";
            buttonNextQuestion.UseVisualStyleBackColor = true;
            buttonNextQuestion.Click += buttonNextQuestion_Click;
            // 
            // UserControlPlayGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonNextQuestion);
            Controls.Add(labelCorrect);
            Controls.Add(buttonCheckAnswer);
            Controls.Add(textBoxAnswer);
            Controls.Add(labelQuestion);
            Controls.Add(labelGameMode);
            Name = "UserControlPlayGame";
            Size = new Size(754, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGameMode;
        private Label labelQuestion;
        private TextBox textBoxAnswer;
        private Button buttonCheckAnswer;
        private Label labelCorrect;
        private Button buttonNextQuestion;
    }
}
