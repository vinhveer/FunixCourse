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
            buttonReplay = new Button();
            label1 = new Label();
            labelScore = new Label();
            SuspendLayout();
            // 
            // labelSuccess
            // 
            labelSuccess.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSuccess.Location = new Point(105, 54);
            labelSuccess.Name = "labelSuccess";
            labelSuccess.Size = new Size(569, 85);
            labelSuccess.TabIndex = 0;
            labelSuccess.Text = "Bạn đã hoàn thành Game";
            labelSuccess.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonReplay
            // 
            buttonReplay.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonReplay.Location = new Point(204, 303);
            buttonReplay.Name = "buttonReplay";
            buttonReplay.Size = new Size(350, 68);
            buttonReplay.TabIndex = 4;
            buttonReplay.Text = "Chơi lại";
            buttonReplay.UseVisualStyleBackColor = true;
            buttonReplay.Click += buttonReplay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 139);
            label1.Name = "label1";
            label1.Size = new Size(259, 38);
            label1.TabIndex = 5;
            label1.Text = "Số điểm của bạn là";
            // 
            // labelScore
            // 
            labelScore.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelScore.Location = new Point(319, 208);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(131, 62);
            labelScore.TabIndex = 6;
            labelScore.Text = "00";
            labelScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserControlEndGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelScore);
            Controls.Add(label1);
            Controls.Add(buttonReplay);
            Controls.Add(labelSuccess);
            Name = "UserControlEndGame";
            Size = new Size(776, 426);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSuccess;
        private Button buttonReplay;
        private Label label1;
        private Label labelScore;
    }
}
