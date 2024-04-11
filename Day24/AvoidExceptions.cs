using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day24
{
    public static class AvoidExceptions
    {
        public static void BadWay(string input)
        {
            // Inefficient way: Using exceptions for flow control
            try
            {
                int number = int.Parse(input);
                Console.WriteLine($"You entered (Exception method): {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }
        }

        public static void GoodWay(string input)
        {
            // Efficient way: Using TryParse for flow control
            if (int.TryParse(input, out int result))
            {
                Console.WriteLine($"You entered (TryParse method): {result}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }
        }
    }
}
