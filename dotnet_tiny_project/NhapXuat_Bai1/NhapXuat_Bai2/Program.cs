namespace NhapXuat_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số thứ nhất: ");
            int soThuNhat = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập số thứ hai: ");
            int soThuHai = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------------");
            Console.WriteLine("Tổng: " + (soThuNhat + soThuHai));
            Console.WriteLine("Hiệu: " + (soThuNhat - soThuHai));
            Console.WriteLine("Tích: " + (soThuNhat * soThuHai));
            Console.WriteLine("Thương: " + (soThuNhat / soThuHai));
        }
    }
}
