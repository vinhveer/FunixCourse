namespace NhapXuat_Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập bán kính hình tròn: ");
            double banKinh = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("--------------------------");
            Console.WriteLine("Chu vi: " + (2 * Math.PI * banKinh));
            Console.WriteLine("Diện tích: " + (Math.PI * banKinh * banKinh));
        }
    }
}
