namespace Bai1_P5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, world!";
            string str_2 = "Hello, world!";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
                str_2 = str_2 + str[i];
            }

            Console.WriteLine(str_2);
        }
    }
}
