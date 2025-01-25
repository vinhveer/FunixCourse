namespace PracticeWindowsForm2
{
    partial class Practice
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
            SuspendLayout();
            // 
            // panelLayout
            // 
            panelLayout.Location = new Point(12, 12);
            panelLayout.Name = "panelLayout";
            panelLayout.Size = new Size(776, 426);
            panelLayout.TabIndex = 0;
            // 
            // Practice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelLayout);
            Name = "Practice";
            Text = "Practice";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLayout;
    }
}
