using Assignment4.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class ThemSinhVienMoi : Form
    {
        private readonly SinhVienContext _context = new SinhVienContext();

        public ThemSinhVienMoi()
        {
            InitializeComponent();

            var lops = _context.Lops.ToList();
            if (lops.Any())
            {
                // Setup ComboBox for Lop
                comboBoxLop.DataSource = lops;
                comboBoxLop.DisplayMember = "TenLop";
                comboBoxLop.ValueMember = "MaLop";
                comboBoxLop.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu lớp!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Setup ComboBox for GioiTinh
            comboBoxGioiTinh.DataSource = new List<string> { "Nam", "Nữ" };
            comboBoxGioiTinh.SelectedIndex = 0;

            // Set default date to current date
            dateTimePickerNgaySinh.Value = DateTime.Now;
        }

        private void buttonLuuSinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(textBoxTenSinhVien.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên sinh viên!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate ComboBox selections
                var selectedValue = comboBoxLop.SelectedValue;
                if (selectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn lớp!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var selectedGender = comboBoxGioiTinh.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedGender))
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get form values
                string tenSv = textBoxTenSinhVien.Text.Trim();
                string gioiTinh = selectedGender;
                DateOnly ngaySinh = DateOnly.FromDateTime(dateTimePickerNgaySinh.Value.Date);

                // Safe unboxing with null check
                if (selectedValue is int maLop)
                {
                    // Validate age
                    var today = DateOnly.FromDateTime(DateTime.Today);
                    var age = today.Year - ngaySinh.Year;
                    if (age < 16 || age > 100)
                    {
                        MessageBox.Show("Tuổi sinh viên không hợp lệ!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Create new SinhVien object
                    var sinhVien = new SinhVien
                    {
                        TenSv = tenSv,
                        GioiTinh = gioiTinh,
                        NgaySinh = ngaySinh,
                        MaLop = maLop
                    };

                    // Add to database
                    _context.SinhViens.Add(sinhVien);
                    _context.SaveChanges();

                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear form
                    textBoxTenSinhVien.Clear();
                    comboBoxGioiTinh.SelectedIndex = 0;
                    dateTimePickerNgaySinh.Value = DateTime.Now;
                    comboBoxLop.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Giá trị lớp không hợp lệ!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sinh viên: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}