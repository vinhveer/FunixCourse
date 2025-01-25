namespace Bai1_P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] % 2 == 0)
                    Console.WriteLine($"Number {i + 1}: {numbers[i]}");
            }
        }
    }
}
