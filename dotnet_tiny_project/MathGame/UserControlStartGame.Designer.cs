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
            label1 = new Label();
            comboBoxChooseLevel = new ComboBox();
            buttonStartGame = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 49);
            label1.Name = "label1";
            label1.Size = new Size(259, 60);
            label1.TabIndex = 0;
            label1.Text = "Math Game";
            // 
            // comboBoxChooseLevel
            // 
            comboBoxChooseLevel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxChooseLevel.FormattingEnabled = true;
            comboBoxChooseLevel.Items.AddRange(new object[] { "Dễ", "Trung bình", "Khó" });
            comboBoxChooseLevel.Location = new Point(232, 175);
            comboBoxChooseLevel.Name = "comboBoxChooseLevel";
            comboBoxChooseLevel.Size = new Size(283, 56);
            comboBoxChooseLevel.TabIndex = 1;
            // 
            // buttonStartGame
            // 
            buttonStartGame.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStartGame.Location = new Point(232, 271);
            buttonStartGame.Name = "buttonStartGame";
            buttonStartGame.Size = new Size(283, 91);
            buttonStartGame.TabIndex = 2;
            buttonStartGame.Text = "Play";
            buttonStartGame.UseVisualStyleBackColor = true;
            buttonStartGame.Click += buttonStartGame_Click;
            // 
            // UserControlStartGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonStartGame);
            Controls.Add(comboBoxChooseLevel);
            Controls.Add(label1);
            Name = "UserControlStartGame";
            Size = new Size(776, 426);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxChooseLevel;
        private Button buttonStartGame;
    }
}
