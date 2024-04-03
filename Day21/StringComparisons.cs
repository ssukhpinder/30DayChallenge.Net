using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day21
{
    public static class StringComparisons
    {
        private static readonly string string1 = "test";
        private static readonly string string2 = "test";
        public static void BadMethod()
        {
            // Inefficient string comparison
            bool equal = string1.ToLower() == string2.ToLower();
            Console.WriteLine($"In bad method strings are {equal}");
        }

        public static void GoodMethod()
        {
            // efficient string comparison
            bool equal = string.Equals(string1, string2, System.StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"In good method strings are {equal}");
        }
    }
}
