namespace ProductManagementStatic
{
    internal class Program
    {
        static int maxSize = 100; // Maximum size of the array
        static Product[] productArray = new Product[maxSize];
        static int currentSize = 0; // Current number of products in the array

        static void AddProduct()
        {
            if (currentSize >= maxSize)
            {
                Console.WriteLine("The array is full.");
                return;
            }

            Console.Write("Enter product ID: ");
            string id = Console.ReadLine()!;
            Console.Write("Enter product name: ");
            string name = Console.ReadLine()!;
            Console.Write("Enter product price: ");
            if (double.TryParse(Console.ReadLine(), out double price))
            {
                productArray[currentSize] = new Product(id, name, price);
                currentSize++;
                Console.WriteLine("Product added successfully!");
            }
            else
            {
                Console.WriteLine("Invalid price. Product not added.");
            }
        }

        static void DisplayProducts()
        {
            if (currentSize == 0)
            {
                Console.WriteLine("No products to display.");
                return;
            }
            else
            {
                Console.WriteLine("List of products:");
                for (int i = 0; i < currentSize; i++)
                {
                    Console.WriteLine(productArray[i]);
                }
            }
        }

        static void SearchProductByName()
        {
            Console.Write("Enter the product name to search: ");
            string name = Console.ReadLine()!;

            bool found = false;

            for (int i = 0; i < currentSize; i++)
            {
                if (productArray[i].Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(productArray[i]);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Product not found.");
            }
        }

        static void DeleteProductById()
        {
            Console.Write("Enter the product ID to delete: ");
            string id = Console.ReadLine()!;
            int indexToDelete = -1;

            for (int i = 0; i < currentSize; i++)
            {
                if (productArray[i].Id == id)
                {
                    indexToDelete = i;
                    break;
                }
            }

            if (indexToDelete != -1)
            {
                // Shift elements to fill the gap
                for (int i = indexToDelete; i < currentSize - 1; i++)
                {
                    productArray[i] = productArray[i + 1];
                }

                productArray[currentSize - 1] = null!; // Clear the last element
                currentSize--;
                Console.WriteLine("Product deleted successfully!");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nProduct Management Menu:");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Display Products");
                Console.WriteLine("3. Search Product by Name");
                Console.WriteLine("4. Delete Product by ID");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine()!;
                switch (choice)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        DisplayProducts();
                        break;
                    case "3":
                        SearchProductByName();
                        break;
                    case "4":
                        DeleteProductById();
                        break;
                    case "5":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            }
        }
    }
}
