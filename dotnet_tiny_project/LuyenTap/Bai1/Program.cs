namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string address;


            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine()!;

            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your address: ");
            address = Console.ReadLine()!;

            Console.WriteLine("Hello, my name is " + name + ", I'm " + age + " years old, and I live in " + address + ".");
        }
    }
}
