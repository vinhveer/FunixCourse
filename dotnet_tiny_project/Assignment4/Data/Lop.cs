using System.ComponentModel;

namespace Assignment4.Data;

public partial class Lop
{
    [DisplayName("Mã lớp")]
    public int MaLop { get; set; }

    [DisplayName("Tên lớp")]
    public string TenLop { get; set; } = null!;

    public virtual ICollection<SinhVien> SinhViens { get; set; } = new List<SinhVien>();

    public override string ToString()
    {
        return TenLop;
    }
}
