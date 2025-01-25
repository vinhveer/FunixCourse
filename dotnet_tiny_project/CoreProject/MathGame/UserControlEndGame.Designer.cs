namespace MathGame
{
    partial class UserControlEndGame
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
            labelSuccess = new Label();
            buttonRePlay = new Button();
            labelScoreSuccess = new Label();
            labelScore = new Label();
            SuspendLayout();
            // 
            // labelSuccess
            // 
            labelSuccess.AutoSize = true;
            labelSuccess.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSuccess.Location = new Point(166, 106);
            labelSuccess.Name = "labelSuccess";
            labelSuccess.Size = new Size(390, 65);
            labelSuccess.TabIndex = 0;
            labelSuccess.Text = "Bạn đã trả lời sai";
            // 
            // buttonRePlay
            // 
            buttonRePlay.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRePlay.Location = new Point(250, 324);
            buttonRePlay.Name = "buttonRePlay";
            buttonRePlay.Size = new Size(218, 57);
            buttonRePlay.TabIndex = 1;
            buttonRePlay.Text = "Chơi lại";
            buttonRePlay.UseVisualStyleBackColor = true;
            buttonRePlay.Click += buttonRePlay_Click;
            // 
            // labelScoreSuccess
            // 
            labelScoreSuccess.AutoSize = true;
            labelScoreSuccess.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelScoreSuccess.Location = new Point(250, 194);
            labelScoreSuccess.Name = "labelScoreSuccess";
            labelScoreSuccess.Size = new Size(218, 32);
            labelScoreSuccess.TabIndex = 2;
            labelScoreSuccess.Text = "Số điểm của bạn là";
            // 
            // labelScore
            // 
            labelScore.Anchor = AnchorStyles.None;
            labelScore.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelScore.Location = new Point(316, 247);
            labelScore.Margin = new Padding(3);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(83, 45);
            labelScore.TabIndex = 3;
            labelScore.Text = "0";
            labelScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserControlEndGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelScore);
            Controls.Add(labelScoreSuccess);
            Controls.Add(buttonRePlay);
            Controls.Add(labelSuccess);
            Name = "UserControlEndGame";
            Size = new Size(754, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSuccess;
        private Button buttonRePlay;
        private Label labelScoreSuccess;
        private Label labelScore;
    }
}
