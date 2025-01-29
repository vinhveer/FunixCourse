namespace Assignment4
{
    partial class ThemSinhVienMoi
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxTenSinhVien = new TextBox();
            dateTimePickerNgaySinh = new DateTimePicker();
            comboBoxGioiTinh = new ComboBox();
            comboBoxLop = new ComboBox();
            buttonLuuSinhVien = new Button();
            SuspendLayout();
            // 
            // textBoxTenSinhVien
            // 
            textBoxTenSinhVien.Location = new Point(12, 12);
            textBoxTenSinhVien.Name = "textBoxTenSinhVien";
            textBoxTenSinhVien.PlaceholderText = "Nhập tên sinh viên";
            textBoxTenSinhVien.Size = new Size(776, 31);
            textBoxTenSinhVien.TabIndex = 0;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Location = new Point(12, 49);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(300, 31);
            dateTimePickerNgaySinh.TabIndex = 1;
            // 
            // comboBoxGioiTinh
            // 
            comboBoxGioiTinh.FormattingEnabled = true;
            comboBoxGioiTinh.Location = new Point(12, 86);
            comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            comboBoxGioiTinh.Size = new Size(182, 33);
            comboBoxGioiTinh.TabIndex = 2;
            // 
            // comboBoxLop
            // 
            comboBoxLop.FormattingEnabled = true;
            comboBoxLop.Location = new Point(12, 125);
            comboBoxLop.Name = "comboBoxLop";
            comboBoxLop.Size = new Size(182, 33);
            comboBoxLop.TabIndex = 3;
            // 
            // buttonLuuSinhVien
            // 
            buttonLuuSinhVien.Location = new Point(12, 234);
            buttonLuuSinhVien.Name = "buttonLuuSinhVien";
            buttonLuuSinhVien.Size = new Size(172, 34);
            buttonLuuSinhVien.TabIndex = 4;
            buttonLuuSinhVien.Text = "Lưu sinh viên";
            buttonLuuSinhVien.UseVisualStyleBackColor = true;
            buttonLuuSinhVien.Click += buttonLuuSinhVien_Click;
            // 
            // ThemSinhVienMoi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLuuSinhVien);
            Controls.Add(comboBoxLop);
            Controls.Add(comboBoxGioiTinh);
            Controls.Add(dateTimePickerNgaySinh);
            Controls.Add(textBoxTenSinhVien);
            Name = "ThemSinhVienMoi";
            Text = "Thêm sinh viên mới";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTenSinhVien;
        private DateTimePicker dateTimePickerNgaySinh;
        private ComboBox comboBoxGioiTinh;
        private ComboBox comboBoxLop;
        private Button buttonLuuSinhVien;
    }
}