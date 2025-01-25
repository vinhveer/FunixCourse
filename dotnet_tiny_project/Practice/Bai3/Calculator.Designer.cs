namespace Bai3
{
    partial class Calculator
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
            textBoxOperation = new TextBox();
            labelResult = new Label();
            buttonDelete = new Button();
            buttonDivide = new Button();
            buttonNumber7 = new Button();
            buttonNumber8 = new Button();
            buttonNumber9 = new Button();
            buttonMultiply = new Button();
            buttonNumber4 = new Button();
            buttonNumber5 = new Button();
            buttonNumber6 = new Button();
            buttonSubtract = new Button();
            buttonNumber1 = new Button();
            buttonNumber2 = new Button();
            buttonNumber3 = new Button();
            buttonPlus = new Button();
            button0 = new Button();
            buttonDot = new Button();
            buttonEquals = new Button();
            SuspendLayout();
            // 
            // textBoxOperation
            // 
            textBoxOperation.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxOperation.Location = new Point(12, 12);
            textBoxOperation.Name = "textBoxOperation";
            textBoxOperation.Size = new Size(418, 61);
            textBoxOperation.TabIndex = 0;
            // 
            // labelResult
            // 
            labelResult.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResult.Location = new Point(277, 76);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(153, 60);
            labelResult.TabIndex = 1;
            labelResult.Text = "0";
            labelResult.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(12, 148);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(312, 70);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "C";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += button1_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDivide.Location = new Point(330, 148);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(100, 70);
            buttonDivide.TabIndex = 5;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += button4_Click;
            // 
            // buttonNumber7
            // 
            buttonNumber7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNumber7.Location = new Point(12, 224);
            buttonNumber7.Name = "buttonNumber7";
            buttonNumber7.Size = new Size(100, 70);
            buttonNumber7.TabIndex = 6;
            buttonNumber7.Text = "7";
            buttonNumber7.UseVisualStyleBackColor = true;
            buttonNumber7.Click += buttonNumber7_Click;
            // 
            // buttonNumber8
            // 
            buttonNumber8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNumber8.Location = new Point(118, 224);
            buttonNumber8.Name = "buttonNumber8";
            buttonNumber8.Size = new Size(100, 70);
            buttonNumber8.TabIndex = 7;
            buttonNumber8.Text = "8";
            buttonNumber8.UseVisualStyleBackColor = true;
            buttonNumber8.Click += buttonNumber8_Click;
            // 
            // buttonNumber9
            // 
            buttonNumber9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNumber9.Location = new Point(224, 224);
            buttonNumber9.Name = "buttonNumber9";
            buttonNumber9.Size = new Size(100, 70);
            buttonNumber9.TabIndex = 8;
            buttonNumber9.Text = "9";
            buttonNumber9.UseVisualStyleBackColor = true;
            buttonNumber9.Click += buttonNumber9_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMultiply.Location = new Point(330, 224);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(100, 70);
            buttonMultiply.TabIndex = 9;
            buttonMultiply.Text = "✕";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonNumber4
            // 
            buttonNumber4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNumber4.Location = new Point(12, 300);
            buttonNumber4.Name = "buttonNumber4";
            buttonNumber4.Size = new Size(100, 70);
            buttonNumber4.TabIndex = 10;
            buttonNumber4.Text = "4";
            buttonNumber4.UseVisualStyleBackColor = true;
            buttonNumber4.Click += buttonNumber4_Click;
            // 
            // buttonNumber5
            // 
            buttonNumber5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNumber5.Location = new Point(118, 300);
            buttonNumber5.Name = "buttonNumber5";
            buttonNumber5.Size = new Size(100, 70);
            buttonNumber5.TabIndex = 11;
            buttonNumber5.Text = "5";
            buttonNumber5.UseVisualStyleBackColor = true;
            buttonNumber5.Click += buttonNumber5_Click;
            // 
            // buttonNumber6
            // 
            buttonNumber6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNumber6.Location = new Point(224, 300);
            buttonNumber6.Name = "buttonNumber6";
            buttonNumber6.Size = new Size(100, 70);
            buttonNumber6.TabIndex = 12;
            buttonNumber6.Text = "6";
            buttonNumber6.UseVisualStyleBackColor = true;
            buttonNumber6.Click += buttonNumber6_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubtract.Location = new Point(329, 300);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(100, 70);
            buttonSubtract.TabIndex = 13;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += buttonSubtract_Click;
            // 
            // buttonNumber1
            // 
            buttonNumber1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNumber1.Location = new Point(12, 376);
            buttonNumber1.Name = "buttonNumber1";
            buttonNumber1.Size = new Size(100, 70);
            buttonNumber1.TabIndex = 14;
            buttonNumber1.Text = "1";
            buttonNumber1.UseVisualStyleBackColor = true;
            buttonNumber1.Click += buttonNumber1_Click;
            // 
            // buttonNumber2
            // 
            buttonNumber2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNumber2.Location = new Point(118, 376);
            buttonNumber2.Name = "buttonNumber2";
            buttonNumber2.Size = new Size(100, 70);
            buttonNumber2.TabIndex = 15;
            buttonNumber2.Text = "2";
            buttonNumber2.UseVisualStyleBackColor = true;
            buttonNumber2.Click += buttonNumber2_Click;
            // 
            // buttonNumber3
            // 
            buttonNumber3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNumber3.Location = new Point(224, 376);
            buttonNumber3.Name = "buttonNumber3";
            buttonNumber3.Size = new Size(100, 70);
            buttonNumber3.TabIndex = 16;
            buttonNumber3.Text = "3";
            buttonNumber3.UseVisualStyleBackColor = true;
            buttonNumber3.Click += buttonNumber3_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPlus.Location = new Point(329, 376);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(100, 70);
            buttonPlus.TabIndex = 17;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button0.Location = new Point(12, 452);
            button0.Name = "button0";
            button0.Size = new Size(100, 70);
            button0.TabIndex = 18;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonDot
            // 
            buttonDot.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDot.Location = new Point(118, 452);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(100, 70);
            buttonDot.TabIndex = 19;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            // 
            // buttonEquals
            // 
            buttonEquals.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEquals.Location = new Point(224, 452);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(205, 70);
            buttonEquals.TabIndex = 20;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 533);
            Controls.Add(buttonEquals);
            Controls.Add(buttonDot);
            Controls.Add(button0);
            Controls.Add(buttonPlus);
            Controls.Add(buttonNumber3);
            Controls.Add(buttonNumber2);
            Controls.Add(buttonNumber1);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonNumber6);
            Controls.Add(buttonNumber5);
            Controls.Add(buttonNumber4);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonNumber9);
            Controls.Add(buttonNumber8);
            Controls.Add(buttonNumber7);
            Controls.Add(buttonDivide);
            Controls.Add(buttonDelete);
            Controls.Add(labelResult);
            Controls.Add(textBoxOperation);
            Name = "Calculator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxOperation;
        private Label labelResult;
        private Button buttonDelete;
        private Button buttonDivide;
        private Button buttonNumber7;
        private Button buttonNumber8;
        private Button buttonNumber9;
        private Button buttonMultiply;
        private Button buttonNumber4;
        private Button buttonNumber5;
        private Button buttonNumber6;
        private Button buttonSubtract;
        private Button buttonNumber1;
        private Button buttonNumber2;
        private Button buttonNumber3;
        private Button buttonPlus;
        private Button button0;
        private Button buttonDot;
        private Button buttonEquals;
    }
}
