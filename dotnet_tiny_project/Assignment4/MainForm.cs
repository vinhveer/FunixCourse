using Assignment4.Data;
namespace Assignment4
{
    public partial class MainForm : Form
    {
        private readonly SinhVienContext _context = new SinhVienContext();

        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Load data for DataGridViews
            dataGridViewLop.DataSource = _context.Lops.ToList();
            dataGridViewSinhVien.DataSource = _context.SinhViens.ToList();

            // Setup ComboBox for Lop filtering
            comboBoxLocTheoLop.DataSource = _context.Lops.ToList();
            comboBoxLocTheoLop.DisplayMember = "TenLop";
            comboBoxLocTheoLop.ValueMember = "MaLop";

            // Setup ComboBox for Gender filtering
            comboBoxLocTheoGioiTinh.DataSource = new List<string> { "Tất cả", "Nam", "Nữ" };
        }

        private void textBoxTimKiemSinhVien_TextChanged(object sender, EventArgs e)
        {
            FilterSinhVien();
        }

        private void comboBoxLocTheoLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSinhVien();
        }

        private void comboBoxLocTheoGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSinhVien();
        }

        private void FilterSinhVien()
        {
            var query = _context.SinhViens.AsQueryable();

            // Filter by name if search text is not empty
            if (!string.IsNullOrWhiteSpace(textBoxTimKiemSinhVien.Text))
            {
                query = query.Where(sv => sv.TenSv.Contains(textBoxTimKiemSinhVien.Text));
            }

            // Filter by class if a class is selected
            if (comboBoxLocTheoLop.SelectedValue != null && comboBoxLocTheoLop.SelectedIndex > 0)
            {
                var selectedMaLop = (int)comboBoxLocTheoLop.SelectedValue;
                query = query.Where(sv => sv.MaLop == selectedMaLop);
            }

            // Filter by gender if gender is selected
            if (comboBoxLocTheoGioiTinh.SelectedItem != null && comboBoxLocTheoGioiTinh.SelectedItem.ToString() != "Tất cả")
            {
                var selectedGender = comboBoxLocTheoGioiTinh.SelectedItem.ToString();
                query = query.Where(sv => sv.GioiTinh == selectedGender);
            }

            // Update DataGridView
            dataGridViewSinhVien.DataSource = query.ToList();
        }

        private void buttonThemSinhVien_Click(object sender, EventArgs e)
        {
            ThemSinhVienMoi themSinhVienMoi = new ThemSinhVienMoi();
            themSinhVienMoi.ShowDialog();

            LoadData();
        }

        private void buttonXoaSinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any rows are selected
                if (dataGridViewSinhVien.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get all selected students
                var selectedStudents = new List<SinhVien>();
                foreach (DataGridViewRow row in dataGridViewSinhVien.SelectedRows)
                {
                    if (row.DataBoundItem is SinhVien sv)
                    {
                        selectedStudents.Add(sv);
                    }
                }

                if (!selectedStudents.Any())
                {
                    MessageBox.Show("Không tìm thấy thông tin sinh viên để xóa!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Build confirmation message
                string message;
                if (selectedStudents.Count == 1)
                {
                    message = $"Bạn có chắc chắn muốn xóa sinh viên {selectedStudents[0].TenSv} không?";
                }
                else
                {
                    message = $"Bạn có chắc chắn muốn xóa {selectedStudents.Count} sinh viên đã chọn không?";
                }

                // Confirm deletion
                var dialogResult = MessageBox.Show(message, "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    // Remove students from database
                    _context.SinhViens.RemoveRange(selectedStudents);
                    _context.SaveChanges();

                    MessageBox.Show(
                        selectedStudents.Count == 1
                            ? "Đã xóa sinh viên thành công!"
                            : $"Đã xóa {selectedStudents.Count} sinh viên thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa sinh viên: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonThemLop_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewLop_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSinhVien_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Đảm bảo không phải header
            {
                // Lấy dòng đang được sửa
                var row = dataGridViewSinhVien.Rows[e.RowIndex];
                if (row.DataBoundItem is SinhVien sinhVien)
                {
                    try
                    {
                        // Cập nhật vào database
                        _context.SaveChanges();
                        MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi cập nhật: {ex.Message}", "Lỗi");
                        // Reload lại data nếu có lỗi
                        LoadData();
                    }
                }
            }
        }
    }
}