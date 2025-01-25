namespace NhapXuat_Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập chiều dài: ");
            double chieuDai = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập chiều rộng: ");
            double chieuRong = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("--------------------------");
            Console.WriteLine("Chu vi: " + (2 * (chieuDai + chieuRong)));
            Console.WriteLine("Diện tích: " + (chieuDai * chieuRong));
        }
    }
}
