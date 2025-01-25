namespace NotePad
{
    partial class Form1
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
            textBoxFileContent = new TextBox();
            btnOpenFile = new Button();
            labelOpenFile = new Label();
            buttonSaveFile = new Button();
            buttonCloseFile = new Button();
            SuspendLayout();
            // 
            // textBoxFileContent
            // 
            textBoxFileContent.Location = new Point(12, 49);
            textBoxFileContent.Multiline = true;
            textBoxFileContent.Name = "textBoxFileContent";
            textBoxFileContent.Size = new Size(1171, 626);
            textBoxFileContent.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(12, 9);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(146, 34);
            btnOpenFile.TabIndex = 1;
            btnOpenFile.Text = "Mở tập tin";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // labelOpenFile
            // 
            labelOpenFile.AutoSize = true;
            labelOpenFile.Location = new Point(164, 14);
            labelOpenFile.Name = "labelOpenFile";
            labelOpenFile.Size = new Size(148, 25);
            labelOpenFile.TabIndex = 2;
            labelOpenFile.Text = "Chưa mở file nào";
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Location = new Point(896, 9);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(139, 34);
            buttonSaveFile.TabIndex = 3;
            buttonSaveFile.Text = "Lưu tập tin";
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // buttonCloseFile
            // 
            buttonCloseFile.Location = new Point(1041, 9);
            buttonCloseFile.Name = "buttonCloseFile";
            buttonCloseFile.Size = new Size(142, 34);
            buttonCloseFile.TabIndex = 4;
            buttonCloseFile.Text = "Đóng tập tin";
            buttonCloseFile.UseVisualStyleBackColor = true;
            buttonCloseFile.Click += buttonCloseFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 687);
            Controls.Add(buttonCloseFile);
            Controls.Add(buttonSaveFile);
            Controls.Add(labelOpenFile);
            Controls.Add(btnOpenFile);
            Controls.Add(textBoxFileContent);
            Name = "Form1";
            Text = "Notepad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFileContent;
        private Button btnOpenFile;
        private Label labelOpenFile;
        private Button buttonSaveFile;
        private Button buttonCloseFile;
    }
}
