namespace ExampleMaxMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of values in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the values: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter value {arr[i]}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"The maximum value is: {max}");

            int min = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"The minimum value is: {min}");
        }
    }
}
