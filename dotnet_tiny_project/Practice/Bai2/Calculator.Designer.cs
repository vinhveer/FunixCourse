namespace Bai2
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
            textBoxPhepTinh = new TextBox();
            labelPhepTinh = new Label();
            labelKetQua = new Label();
            SuspendLayout();
            // 
            // textBoxPhepTinh
            // 
            textBoxPhepTinh.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            textBoxPhepTinh.Location = new Point(12, 40);
            textBoxPhepTinh.Name = "textBoxPhepTinh";
            textBoxPhepTinh.Size = new Size(776, 50);
            textBoxPhepTinh.TabIndex = 0;
            textBoxPhepTinh.TextChanged += textBoxPhepTinh_TextChanged;
            // 
            // labelPhepTinh
            // 
            labelPhepTinh.AutoSize = true;
            labelPhepTinh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPhepTinh.Location = new Point(12, 9);
            labelPhepTinh.Name = "labelPhepTinh";
            labelPhepTinh.Size = new Size(149, 28);
            labelPhepTinh.TabIndex = 1;
            labelPhepTinh.Text = "Nhập phép tính";
            // 
            // labelKetQua
            // 
            labelKetQua.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            labelKetQua.Location = new Point(700, 93);
            labelKetQua.Name = "labelKetQua";
            labelKetQua.Size = new Size(88, 58);
            labelKetQua.TabIndex = 2;
            labelKetQua.Text = "0";
            labelKetQua.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelKetQua);
            Controls.Add(labelPhepTinh);
            Controls.Add(textBoxPhepTinh);
            Name = "Calculator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPhepTinh;
        private Label labelPhepTinh;
        private Label labelKetQua;
    }
}
