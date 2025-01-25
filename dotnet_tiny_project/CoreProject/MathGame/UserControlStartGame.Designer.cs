namespace MathGame
{
    partial class UserControlStartGame
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
            buttonPlayGame = new Button();
            comboBoxLevel = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonPlayGame
            // 
            buttonPlayGame.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPlayGame.Location = new Point(283, 284);
            buttonPlayGame.Name = "buttonPlayGame";
            buttonPlayGame.Size = new Size(187, 84);
            buttonPlayGame.TabIndex = 0;
            buttonPlayGame.Text = "Chơi";
            buttonPlayGame.UseVisualStyleBackColor = true;
            buttonPlayGame.Click += buttonPlayGame_Click;
            // 
            // comboBoxLevel
            // 
            comboBoxLevel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxLevel.FormattingEnabled = true;
            comboBoxLevel.Items.AddRange(new object[] { "Dễ", "Trung bình", "Khó" });
            comboBoxLevel.Location = new Point(49, 187);
            comboBoxLevel.Name = "comboBoxLevel";
            comboBoxLevel.Size = new Size(665, 53);
            comboBoxLevel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 127);
            label1.Name = "label1";
            label1.Size = new Size(201, 45);
            label1.TabIndex = 2;
            label1.Text = "Chọn chế độ";
            // 
            // UserControlStartGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(comboBoxLevel);
            Controls.Add(buttonPlayGame);
            Name = "UserControlStartGame";
            Size = new Size(754, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPlayGame;
        private ComboBox comboBoxLevel;
        private Label label1;
    }
}
