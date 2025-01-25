namespace PracticeWindowsForm2
{
    partial class UserControlStart
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
            buttonNextPage = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonNextPage
            // 
            buttonNextPage.Location = new Point(646, 17);
            buttonNextPage.Name = "buttonNextPage";
            buttonNextPage.Size = new Size(112, 34);
            buttonNextPage.TabIndex = 0;
            buttonNextPage.Text = "Next Page";
            buttonNextPage.UseVisualStyleBackColor = true;
            buttonNextPage.Click += buttonNextPage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 63);
            label1.Name = "label1";
            label1.Size = new Size(370, 60);
            label1.TabIndex = 1;
            label1.Text = "User Control Start";
            // 
            // UserControlStart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(buttonNextPage);
            Name = "UserControlStart";
            Size = new Size(776, 426);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNextPage;
        private Label label1;
    }
}
