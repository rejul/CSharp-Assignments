using System;

class Program
{

    //Write a program in C# to calculate and print the 
    // Electricity bill of a given customer. The customer id., 
    // name and unit consumed by the user should be taken 
    // from the keyboard and display the total amount to pay 
    // to the customer

    #region Main Method
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Enter Customer ID: ");
        int customerId = int.Parse(Console.ReadLine());

        Console.Write("Enter Customer Name: ");
        string customerName = Console.ReadLine();

        Console.Write("Enter Units Consumed: ");
        double units = double.Parse(Console.ReadLine());

        // Calculate bill
        double totalAmount = CalculateBill(units, out double chargePerUnit);

        // Display bill
        DisplayBill(customerId, customerName, units, chargePerUnit, totalAmount);
    }
    #endregion

    #region Bill Calculation
    static double CalculateBill(double units, out double chargePerUnit)
    {
        if (units < 200)
        {
            chargePerUnit = 1.20;
        }
        else if (units < 400)
        {
            chargePerUnit = 1.50;
        }
        else if (units < 600)
        {
            chargePerUnit = 1.80;
        }
        else
        {
            chargePerUnit = 2.00;
        }

        return units * chargePerUnit;
    }
    #endregion

    #region Display Bill
    static void DisplayBill(int customerId, string customerName, double units, double chargePerUnit, double totalAmount)
    {
        Console.WriteLine("\n--- Electricity Bill ---");
        Console.WriteLine($"Customer ID   : {customerId}");
        Console.WriteLine($"Customer Name : {customerName}");
        Console.WriteLine($"Units Consumed: {units}");
        Console.WriteLine($"Charge/Unit   : ₹ {chargePerUnit}");
        Console.WriteLine($"Total Amount  : ₹ {totalAmount}");
    }
    #endregion
}