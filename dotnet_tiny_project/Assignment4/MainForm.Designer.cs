namespace Assignment4
{
    partial class MainForm
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
            tabControl1 = new TabControl();
            tabPageSinhVien = new TabPage();
            dataGridViewSinhVien = new DataGridView();
            comboBoxLocTheoGioiTinh = new ComboBox();
            comboBoxLocTheoLop = new ComboBox();
            buttonXoaSinhVien = new Button();
            buttonThemSinhVien = new Button();
            textBoxTimKiemSinhVien = new TextBox();
            tabPageLop = new TabPage();
            dataGridViewLop = new DataGridView();
            buttonXoaLop = new Button();
            buttonThemLop = new Button();
            textBoxTimKiemLop = new TextBox();
            tabControl1.SuspendLayout();
            tabPageSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).BeginInit();
            tabPageLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLop).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageSinhVien);
            tabControl1.Controls.Add(tabPageLop);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1048, 532);
            tabControl1.TabIndex = 0;
            // 
            // tabPageSinhVien
            // 
            tabPageSinhVien.Controls.Add(dataGridViewSinhVien);
            tabPageSinhVien.Controls.Add(comboBoxLocTheoGioiTinh);
            tabPageSinhVien.Controls.Add(comboBoxLocTheoLop);
            tabPageSinhVien.Controls.Add(buttonXoaSinhVien);
            tabPageSinhVien.Controls.Add(buttonThemSinhVien);
            tabPageSinhVien.Controls.Add(textBoxTimKiemSinhVien);
            tabPageSinhVien.Location = new Point(4, 34);
            tabPageSinhVien.Name = "tabPageSinhVien";
            tabPageSinhVien.Padding = new Padding(3);
            tabPageSinhVien.Size = new Size(1040, 494);
            tabPageSinhVien.TabIndex = 0;
            tabPageSinhVien.Text = "Danh sách sinh viên";
            tabPageSinhVien.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSinhVien
            // 
            dataGridViewSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSinhVien.Location = new Point(6, 88);
            dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            dataGridViewSinhVien.RowHeadersWidth = 62;
            dataGridViewSinhVien.Size = new Size(1028, 400);
            dataGridViewSinhVien.TabIndex = 5;
            dataGridViewSinhVien.CellValueChanged += dataGridViewSinhVien_CellValueChanged;
            // 
            // comboBoxLocTheoGioiTinh
            // 
            comboBoxLocTheoGioiTinh.FormattingEnabled = true;
            comboBoxLocTheoGioiTinh.Location = new Point(418, 49);
            comboBoxLocTheoGioiTinh.Name = "comboBoxLocTheoGioiTinh";
            comboBoxLocTheoGioiTinh.Size = new Size(182, 33);
            comboBoxLocTheoGioiTinh.TabIndex = 4;
            comboBoxLocTheoGioiTinh.SelectedIndexChanged += comboBoxLocTheoGioiTinh_SelectedIndexChanged;
            // 
            // comboBoxLocTheoLop
            // 
            comboBoxLocTheoLop.FormattingEnabled = true;
            comboBoxLocTheoLop.Location = new Point(6, 49);
            comboBoxLocTheoLop.Name = "comboBoxLocTheoLop";
            comboBoxLocTheoLop.Size = new Size(406, 33);
            comboBoxLocTheoLop.TabIndex = 3;
            comboBoxLocTheoLop.SelectedIndexChanged += comboBoxLocTheoLop_SelectedIndexChanged;
            // 
            // buttonXoaSinhVien
            // 
            buttonXoaSinhVien.Location = new Point(206, 9);
            buttonXoaSinhVien.Name = "buttonXoaSinhVien";
            buttonXoaSinhVien.Size = new Size(206, 34);
            buttonXoaSinhVien.TabIndex = 2;
            buttonXoaSinhVien.Text = "Xoá sinh viên đã chọn";
            buttonXoaSinhVien.UseVisualStyleBackColor = true;
            buttonXoaSinhVien.Click += buttonXoaSinhVien_Click;
            // 
            // buttonThemSinhVien
            // 
            buttonThemSinhVien.Location = new Point(6, 9);
            buttonThemSinhVien.Name = "buttonThemSinhVien";
            buttonThemSinhVien.Size = new Size(194, 34);
            buttonThemSinhVien.TabIndex = 1;
            buttonThemSinhVien.Text = "Thêm sinh viên mới";
            buttonThemSinhVien.UseVisualStyleBackColor = true;
            buttonThemSinhVien.Click += buttonThemSinhVien_Click;
            // 
            // textBoxTimKiemSinhVien
            // 
            textBoxTimKiemSinhVien.Location = new Point(418, 11);
            textBoxTimKiemSinhVien.Name = "textBoxTimKiemSinhVien";
            textBoxTimKiemSinhVien.PlaceholderText = "Tìm kiếm sinh viên ...";
            textBoxTimKiemSinhVien.Size = new Size(616, 31);
            textBoxTimKiemSinhVien.TabIndex = 0;
            textBoxTimKiemSinhVien.TextChanged += textBoxTimKiemSinhVien_TextChanged;
            // 
            // tabPageLop
            // 
            tabPageLop.Controls.Add(dataGridViewLop);
            tabPageLop.Controls.Add(buttonXoaLop);
            tabPageLop.Controls.Add(buttonThemLop);
            tabPageLop.Controls.Add(textBoxTimKiemLop);
            tabPageLop.Location = new Point(4, 34);
            tabPageLop.Name = "tabPageLop";
            tabPageLop.Padding = new Padding(3);
            tabPageLop.Size = new Size(1040, 494);
            tabPageLop.TabIndex = 1;
            tabPageLop.Text = "Danh sách lớp";
            tabPageLop.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLop
            // 
            dataGridViewLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLop.Location = new Point(6, 48);
            dataGridViewLop.Name = "dataGridViewLop";
            dataGridViewLop.RowHeadersWidth = 62;
            dataGridViewLop.Size = new Size(1028, 439);
            dataGridViewLop.TabIndex = 9;
            dataGridViewLop.CellValueChanged += dataGridViewLop_CellValueChanged;
            // 
            // buttonXoaLop
            // 
            buttonXoaLop.Location = new Point(206, 8);
            buttonXoaLop.Name = "buttonXoaLop";
            buttonXoaLop.Size = new Size(206, 34);
            buttonXoaLop.TabIndex = 8;
            buttonXoaLop.Text = "Xoá lớp đã chọn";
            buttonXoaLop.UseVisualStyleBackColor = true;
            // 
            // buttonThemLop
            // 
            buttonThemLop.Location = new Point(6, 8);
            buttonThemLop.Name = "buttonThemLop";
            buttonThemLop.Size = new Size(194, 34);
            buttonThemLop.TabIndex = 7;
            buttonThemLop.Text = "Thêm lớp mới";
            buttonThemLop.UseVisualStyleBackColor = true;
            buttonThemLop.Click += buttonThemLop_Click;
            // 
            // textBoxTimKiemLop
            // 
            textBoxTimKiemLop.Location = new Point(418, 10);
            textBoxTimKiemLop.Name = "textBoxTimKiemLop";
            textBoxTimKiemLop.PlaceholderText = "Tìm kiếm lớp";
            textBoxTimKiemLop.Size = new Size(616, 31);
            textBoxTimKiemLop.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 556);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Quản lý sinh viên";
            tabControl1.ResumeLayout(false);
            tabPageSinhVien.ResumeLayout(false);
            tabPageSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).EndInit();
            tabPageLop.ResumeLayout(false);
            tabPageLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLop).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageSinhVien;
        private TabPage tabPageLop;
        private Button buttonXoaSinhVien;
        private Button buttonThemSinhVien;
        private TextBox textBoxTimKiemSinhVien;
        private ComboBox comboBoxLocTheoLop;
        private ComboBox comboBoxLocTheoGioiTinh;
        private DataGridView dataGridViewSinhVien;
        private DataGridView dataGridViewLop;
        private Button buttonXoaLop;
        private Button buttonThemLop;
        private TextBox textBoxTimKiemLop;
    }
}
