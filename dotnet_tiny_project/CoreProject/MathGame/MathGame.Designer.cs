namespace MathGame
{
    partial class MathGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLayout = new Panel();
            labelTittle = new Label();
            SuspendLayout();
            // 
            // panelLayout
            // 
            panelLayout.Location = new Point(12, 82);
            panelLayout.Name = "panelLayout";
            panelLayout.Size = new Size(754, 450);
            panelLayout.TabIndex = 0;
            // 
            // labelTittle
            // 
            labelTittle.AutoSize = true;
            labelTittle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTittle.Location = new Point(12, 19);
            labelTittle.Name = "labelTittle";
            labelTittle.Size = new Size(186, 45);
            labelTittle.TabIndex = 1;
            labelTittle.Text = "Math Game";
            // 
            // MathGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(labelTittle);
            Controls.Add(panelLayout);
            Name = "MathGame";
            Text = "Math Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLayout;
        private Label labelTittle;
    }
}
