using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollectionE.Validation
{
    public static class InputHelper
    {
        public static string GetString(string prompt)
        {
      
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine()?.Trim();
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }

        public static int GetInt(string prompt, int min = int.MinValue, int max = int.MaxValue)
        {
            int value;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out value) || value < min || value > max)
            {
                Console.Write($"Invalid input. {prompt}");
            }
            return value;
        }

        public static double GetDouble(string prompt, double min = double.MinValue, double max = double.MaxValue)
        {
            double value;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out value) || value < min || value > max)
            {
                Console.Write($"Invalid input. {prompt}");
            }
            return value;
        }

        public static bool GetBool(string prompt)
        {
            Console.Write($"{prompt} (y/n): ");
            string input;
            while (true)
            {
                input = Console.ReadLine()?.Trim().ToLower();
                if (input == "y" || input == "yes") return true;
                if (input == "n" || input == "no") return false;
                Console.Write("Invalid input. Enter y/n: ");
            }
        }
    }

}
