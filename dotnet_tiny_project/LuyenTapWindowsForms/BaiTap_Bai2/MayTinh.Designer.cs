namespace BaiTap_Bai2
{
    partial class MayTinh
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
            textBoxNhapBieuThuc = new TextBox();
            textBoxKetQua = new TextBox();
            labelNhapPhepTinh = new Label();
            labelKetQua = new Label();
            SuspendLayout();
            // 
            // textBoxNhapBieuThuc
            // 
            textBoxNhapBieuThuc.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNhapBieuThuc.Location = new Point(12, 37);
            textBoxNhapBieuThuc.Name = "textBoxNhapBieuThuc";
            textBoxNhapBieuThuc.Size = new Size(776, 50);
            textBoxNhapBieuThuc.TabIndex = 0;
            textBoxNhapBieuThuc.TextChanged += textBoxNhapBieuThuc_TextChanged;
            // 
            // textBoxKetQua
            // 
            textBoxKetQua.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxKetQua.Location = new Point(12, 178);
            textBoxKetQua.Name = "textBoxKetQua";
            textBoxKetQua.Size = new Size(776, 55);
            textBoxKetQua.TabIndex = 1;
            // 
            // labelNhapPhepTinh
            // 
            labelNhapPhepTinh.AutoSize = true;
            labelNhapPhepTinh.Location = new Point(12, 9);
            labelNhapPhepTinh.Name = "labelNhapPhepTinh";
            labelNhapPhepTinh.Size = new Size(204, 25);
            labelNhapPhepTinh.TabIndex = 2;
            labelNhapPhepTinh.Text = "Nhập phép tính vào đây";
            // 
            // labelKetQua
            // 
            labelKetQua.AutoSize = true;
            labelKetQua.Location = new Point(12, 150);
            labelKetQua.Name = "labelKetQua";
            labelKetQua.Size = new Size(72, 25);
            labelKetQua.TabIndex = 3;
            labelKetQua.Text = "Kết quả";
            // 
            // MayTinh
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelKetQua);
            Controls.Add(labelNhapPhepTinh);
            Controls.Add(textBoxKetQua);
            Controls.Add(textBoxNhapBieuThuc);
            Name = "MayTinh";
            Text = "Máy tính";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNhapBieuThuc;
        private TextBox textBoxKetQua;
        private Label labelNhapPhepTinh;
        private Label labelKetQua;
    }
}
