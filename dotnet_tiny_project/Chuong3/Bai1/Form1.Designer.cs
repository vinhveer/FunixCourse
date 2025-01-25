namespace Bai1
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
            textBoxInputName = new TextBox();
            buttonHienThiLoiChao = new Button();
            SuspendLayout();
            // 
            // textBoxInputName
            // 
            textBoxInputName.Location = new Point(12, 12);
            textBoxInputName.Name = "textBoxInputName";
            textBoxInputName.Size = new Size(776, 31);
            textBoxInputName.TabIndex = 0;
            // 
            // buttonHienThiLoiChao
            // 
            buttonHienThiLoiChao.Location = new Point(12, 49);
            buttonHienThiLoiChao.Name = "buttonHienThiLoiChao";
            buttonHienThiLoiChao.Size = new Size(253, 34);
            buttonHienThiLoiChao.TabIndex = 1;
            buttonHienThiLoiChao.Text = "Hiển thị lời chào";
            buttonHienThiLoiChao.UseVisualStyleBackColor = true;
            buttonHienThiLoiChao.Click += buttonHienThiLoiChao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHienThiLoiChao);
            Controls.Add(textBoxInputName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInputName;
        private Button buttonHienThiLoiChao;
    }
}
