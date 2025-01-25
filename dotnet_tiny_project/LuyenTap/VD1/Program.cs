namespace Bai1_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("The number is zero.");
            }
            else if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else
            {
                Console.WriteLine("The number is negative.");
            }
        }
    }
}
