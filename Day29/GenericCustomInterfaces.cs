using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day29
{
    public interface INumber<T>
    {
        T Value { get; set; }
    }

    public class Number<T> : INumber<T>
    {
        public T Value { get; set; }

        public Number(T value)
        {
            Value = value;
        }
    }
    public static class GenericCustomInterfaces
    {
        static List<INumber<int>> intNumbers = new List<INumber<int>>();
        static List<INumber<double>> doubleNumbers = new List<INumber<double>>();

        public static void Example()
        {
            // Populate the list with integers
            for (int i = 0; i < 10; i++)
            {
                intNumbers.Add(new Number<int>(i));
            }

            // Populate the list with doubles
            for (double d = 0.5; d < 10.0; d += 1.0)
            {
                doubleNumbers.Add(new Number<double>(d));
            }

            // Process and display integer numbers
            Console.WriteLine("Integer Numbers:");
            foreach (var num in intNumbers)
            {
                Console.WriteLine(num.Value);
            }

            // Process and display double numbers
            Console.WriteLine("\nDouble Numbers:");
            foreach (var num in doubleNumbers)
            {
                Console.WriteLine(num.Value);
            }
        }

    }
}
