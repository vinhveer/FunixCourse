namespace Bai2
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
            labelTitle = new Label();
            textBoxNumber1 = new TextBox();
            textBoxNumber2 = new TextBox();
            lblTxt1 = new Label();
            lblTxt2 = new Label();
            buttonCalculate = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(353, 38);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Ứng dụng tính tổng hai số";
            // 
            // textBoxNumber1
            // 
            textBoxNumber1.Location = new Point(12, 112);
            textBoxNumber1.Name = "textBoxNumber1";
            textBoxNumber1.Size = new Size(776, 31);
            textBoxNumber1.TabIndex = 1;
            textBoxNumber1.TextChanged += textBoxNumber1_TextChanged;
            // 
            // textBoxNumber2
            // 
            textBoxNumber2.Location = new Point(12, 189);
            textBoxNumber2.Name = "textBoxNumber2";
            textBoxNumber2.Size = new Size(776, 31);
            textBoxNumber2.TabIndex = 2;
            // 
            // lblTxt1
            // 
            lblTxt1.AutoSize = true;
            lblTxt1.Location = new Point(12, 84);
            lblTxt1.Name = "lblTxt1";
            lblTxt1.Size = new Size(151, 25);
            lblTxt1.TabIndex = 3;
            lblTxt1.Text = "Nhập số thứ nhất";
            // 
            // lblTxt2
            // 
            lblTxt2.AutoSize = true;
            lblTxt2.Location = new Point(12, 161);
            lblTxt2.Name = "lblTxt2";
            lblTxt2.Size = new Size(139, 25);
            lblTxt2.TabIndex = 4;
            lblTxt2.Text = "Nhập số thứ hai";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(12, 240);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(112, 34);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "Tính toán";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelResult.Location = new Point(12, 310);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 38);
            labelResult.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(buttonCalculate);
            Controls.Add(lblTxt2);
            Controls.Add(lblTxt1);
            Controls.Add(textBoxNumber2);
            Controls.Add(textBoxNumber1);
            Controls.Add(labelTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox textBoxNumber1;
        private TextBox textBoxNumber2;
        private Label lblTxt1;
        private Label lblTxt2;
        private Button buttonCalculate;
        private Label labelResult;
    }
}
