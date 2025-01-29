using System.ComponentModel;  // Add this for DisplayName attribute

namespace Assignment4.Data;

public partial class SinhVien
{
    [DisplayName("Mã sinh viên")]
    public int MaSv { get; set; }

    [DisplayName("Tên sinh viên")]
    public string TenSv { get; set; } = null!;

    [DisplayName("Ngày sinh")]
    public DateOnly NgaySinh { get; set; }

    [DisplayName("Giới tính")]
    public string GioiTinh { get; set; } = null!;

    [DisplayName("Mã lớp")]
    public int MaLop { get; set; }

    [DisplayName("Lớp")]
    public virtual Lop MaLopNavigation { get; set; } = null!;
}