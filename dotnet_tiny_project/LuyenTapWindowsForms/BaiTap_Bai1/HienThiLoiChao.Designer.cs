namespace BaiTap_Bai1
{
    partial class HienThiLoiChao
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
            labelNhapHoTen = new Label();
            textBoxNhapHoTen = new TextBox();
            buttonHelloMessageBox = new Button();
            buttonHelloLabel = new Button();
            labelHello = new Label();
            textBoxHello = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelNhapHoTen
            // 
            labelNhapHoTen.AutoSize = true;
            labelNhapHoTen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNhapHoTen.Location = new Point(12, 9);
            labelNhapHoTen.Name = "labelNhapHoTen";
            labelNhapHoTen.Size = new Size(194, 28);
            labelNhapHoTen.TabIndex = 0;
            labelNhapHoTen.Text = "Nhập họ tên của bạn";
            // 
            // textBoxNhapHoTen
            // 
            textBoxNhapHoTen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNhapHoTen.Location = new Point(12, 40);
            textBoxNhapHoTen.Name = "textBoxNhapHoTen";
            textBoxNhapHoTen.Size = new Size(776, 34);
            textBoxNhapHoTen.TabIndex = 1;
            textBoxNhapHoTen.TextChanged += textBoxNhapHoTen_TextChanged;
            // 
            // buttonHelloMessageBox
            // 
            buttonHelloMessageBox.Location = new Point(12, 80);
            buttonHelloMessageBox.Name = "buttonHelloMessageBox";
            buttonHelloMessageBox.Size = new Size(326, 34);
            buttonHelloMessageBox.TabIndex = 2;
            buttonHelloMessageBox.Text = "Hiển thị lời chào qua MessageBox";
            buttonHelloMessageBox.UseVisualStyleBackColor = true;
            buttonHelloMessageBox.Click += buttonHelloMessageBox_Click;
            // 
            // buttonHelloLabel
            // 
            buttonHelloLabel.Location = new Point(344, 80);
            buttonHelloLabel.Name = "buttonHelloLabel";
            buttonHelloLabel.Size = new Size(258, 34);
            buttonHelloLabel.TabIndex = 3;
            buttonHelloLabel.Text = "Hiển thị lời chào qua Label";
            buttonHelloLabel.UseVisualStyleBackColor = true;
            buttonHelloLabel.Click += buttonHelloLabel_Click;
            // 
            // labelHello
            // 
            labelHello.AutoSize = true;
            labelHello.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHello.Location = new Point(12, 162);
            labelHello.Name = "labelHello";
            labelHello.Size = new Size(0, 38);
            labelHello.TabIndex = 4;
            // 
            // textBoxHello
            // 
            textBoxHello.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxHello.Location = new Point(12, 240);
            textBoxHello.Name = "textBoxHello";
            textBoxHello.Size = new Size(776, 39);
            textBoxHello.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(12, 120);
            button1.Name = "button1";
            button1.Size = new Size(326, 34);
            button1.TabIndex = 6;
            button1.Text = "Hiển thị lời chào qua TextBox";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HienThiLoiChao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxHello);
            Controls.Add(labelHello);
            Controls.Add(buttonHelloLabel);
            Controls.Add(buttonHelloMessageBox);
            Controls.Add(textBoxNhapHoTen);
            Controls.Add(labelNhapHoTen);
            Name = "HienThiLoiChao";
            Text = "Hiển thị lời chào";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNhapHoTen;
        private TextBox textBoxNhapHoTen;
        private Button buttonHelloMessageBox;
        private Button buttonHelloLabel;
        private Label labelHello;
        private TextBox textBoxHello;
        private Button button1;
    }
}
