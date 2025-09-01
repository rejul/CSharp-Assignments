using ClassAssignment1.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> acc = new List<Product>();

            while (true)
            {
                Console.WriteLine("\nEnter the Choice : \n1. Add A Product \n2. Sell A Product \n3. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Product product = new Product();   //  create a new product each time
                        Console.WriteLine("Enter The Product Name");
                        product.ProductName = Console.ReadLine();

                        Console.WriteLine("Enter The Product Price");
                        product.Price = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter The Stock Quantity");
                        product.AddStock(Convert.ToInt32(Console.ReadLine()));

                        acc.Add(product);  //  add product to list
                        Console.WriteLine($"Product {product.ProductName} added successfully!");
                        Console.WriteLine(product);
                        break;

                    case 2:
                        Console.WriteLine("Enter The Product Name");
                        string productName = Console.ReadLine();

                        Product foundProduct = acc.FirstOrDefault(p => p.ProductName == productName);

                        if (foundProduct != null)
                        {
                            Console.WriteLine("Enter The Quantity To Sell");
                            int quantityToSell = Convert.ToInt32(Console.ReadLine());

                            try
                            {
                                foundProduct.Sell(quantityToSell);
                                Console.WriteLine(foundProduct); break;

                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Product not found.");
                        }
                        break;
                                               

                    case 3:
                        Console.WriteLine("Exiting...");
                        return; //  exit the program

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
