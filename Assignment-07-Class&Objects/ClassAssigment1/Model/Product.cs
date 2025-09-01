using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment1.Model
{
    public class Product
    {
        public string? ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        //constructor
        public Product()
        {

        }

        public void AddStock(int quantity)
        {
            if (quantity > 0)
            {
                StockQuantity += quantity;
            }
            else
            {
                // Handle invalid quantity
                throw new ArgumentException("Quantity must be greater than zero.");
            }
        }

        public void Sell(int quantity)
        {
            if (quantity > 0 && quantity <= StockQuantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                // Handle invalid quantity
                throw new ArgumentException("Invalid quantity to sell.");
            }
        }

        public override string? ToString()
        {
            return $"Product Name: {ProductName}, Price: {Price}, Stock Quantity: {StockQuantity}";
        }
    }
}
