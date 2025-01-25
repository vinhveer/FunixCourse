namespace Bai3
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
            labelNumber1 = new Label();
            textBoxNumber1 = new TextBox();
            labelNumber2 = new Label();
            textBoxNumber2 = new TextBox();
            buttonCong = new Button();
            buttonTru = new Button();
            buttonNhan = new Button();
            buttonChia = new Button();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(18, 22);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(129, 38);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Máy tính";
            // 
            // labelNumber1
            // 
            labelNumber1.AutoSize = true;
            labelNumber1.Location = new Point(18, 85);
            labelNumber1.Name = "labelNumber1";
            labelNumber1.Size = new Size(151, 25);
            labelNumber1.TabIndex = 1;
            labelNumber1.Text = "Nhập số thứ nhất";
            // 
            // textBoxNumber1
            // 
            textBoxNumber1.Location = new Point(18, 113);
            textBoxNumber1.Name = "textBoxNumber1";
            textBoxNumber1.Size = new Size(770, 31);
            textBoxNumber1.TabIndex = 2;
            // 
            // labelNumber2
            // 
            labelNumber2.AutoSize = true;
            labelNumber2.Location = new Point(18, 156);
            labelNumber2.Name = "labelNumber2";
            labelNumber2.Size = new Size(139, 25);
            labelNumber2.TabIndex = 3;
            labelNumber2.Text = "Nhập số thứ hai";
            // 
            // textBoxNumber2
            // 
            textBoxNumber2.Location = new Point(18, 184);
            textBoxNumber2.Name = "textBoxNumber2";
            textBoxNumber2.Size = new Size(770, 31);
            textBoxNumber2.TabIndex = 4;
            // 
            // buttonCong
            // 
            buttonCong.Location = new Point(18, 243);
            buttonCong.Name = "buttonCong";
            buttonCong.Size = new Size(112, 34);
            buttonCong.TabIndex = 5;
            buttonCong.Text = "Cộng";
            buttonCong.UseVisualStyleBackColor = true;
            buttonCong.Click += buttonCong_Click;
            // 
            // buttonTru
            // 
            buttonTru.Location = new Point(136, 243);
            buttonTru.Name = "buttonTru";
            buttonTru.Size = new Size(112, 34);
            buttonTru.TabIndex = 6;
            buttonTru.Text = "Trừ";
            buttonTru.UseVisualStyleBackColor = true;
            buttonTru.Click += buttonTru_Click;
            // 
            // buttonNhan
            // 
            buttonNhan.Location = new Point(254, 243);
            buttonNhan.Name = "buttonNhan";
            buttonNhan.Size = new Size(112, 34);
            buttonNhan.TabIndex = 7;
            buttonNhan.Text = "Nhân";
            buttonNhan.UseVisualStyleBackColor = true;
            buttonNhan.Click += buttonNhan_Click;
            // 
            // buttonChia
            // 
            buttonChia.Location = new Point(372, 243);
            buttonChia.Name = "buttonChia";
            buttonChia.Size = new Size(112, 34);
            buttonChia.TabIndex = 8;
            buttonChia.Text = "Chia";
            buttonChia.UseVisualStyleBackColor = true;
            buttonChia.Click += buttonChia_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxResult.Location = new Point(21, 316);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(767, 39);
            textBoxResult.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResult);
            Controls.Add(buttonChia);
            Controls.Add(buttonNhan);
            Controls.Add(buttonTru);
            Controls.Add(buttonCong);
            Controls.Add(textBoxNumber2);
            Controls.Add(labelNumber2);
            Controls.Add(textBoxNumber1);
            Controls.Add(labelNumber1);
            Controls.Add(labelTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelNumber1;
        private TextBox textBoxNumber1;
        private Label labelNumber2;
        private TextBox textBoxNumber2;
        private Button buttonCong;
        private Button buttonTru;
        private Button buttonNhan;
        private Button buttonChia;
        private TextBox textBoxResult;
    }
}
