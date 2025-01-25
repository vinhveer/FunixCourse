namespace NhapXuat_Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập họ và tên của bạn: ");
            string hoTen = Console.ReadLine()!;

            Console.Write("Nhập tuổi của bạn: ");
            int tuoi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập địa chỉ của bạn: ");
            string diaChi = Console.ReadLine()!;

            Console.WriteLine("--------------------------");
            Console.WriteLine("Họ và tên: " + hoTen);
            Console.WriteLine("Tuổi: " + tuoi);
            Console.WriteLine("Địa chỉ: " + diaChi);
        }
    }
}
