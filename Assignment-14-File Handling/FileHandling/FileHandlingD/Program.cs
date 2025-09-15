namespace FileHandlingD
{
    internal class Program
    {
        // Product entity
        public class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal ProductPrice { get; set; }
            public int Qty { get; set; }
        }

        static void Main()
        {
            List<Product> products = new List<Product>();

            Console.WriteLine("Enter details for 10 products:\n");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Product {i + 1}:");

                // Product Id
                Console.Write("Enter Product Id: ");
                int id = int.Parse(Console.ReadLine());

                // Product Name
                Console.Write("Enter Product Name: ");
                string name = Console.ReadLine();

                // Product Price
                Console.Write("Enter Product Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                // Quantity
                Console.Write("Enter Quantity: ");
                int qty = int.Parse(Console.ReadLine());

                products.Add(new Product
                {
                    ProductId = id,
                    ProductName = name,
                    ProductPrice = price,
                    Qty = qty
                });

                Console.WriteLine();
            }

            string filePath = "product.csv";

            // Create file if it doesn't exist and append data
            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                foreach (var product in products)
                {
                    // CSV format: 100,apple,120,30
                    string line = $"{product.ProductId},{product.ProductName},{product.ProductPrice},{product.Qty}";
                    writer.WriteLine(line);
                }
            }

            Console.WriteLine($"\nAll products saved/appended in {Path.GetFullPath(filePath)}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
