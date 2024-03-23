using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _30DayChallenge.Net.Day11
{
    public static class ArrayHelperMethods
    {
        /// <summary>
        /// Outputs
        /// Before Sorting...
        /// B14, A11, B12, A13
        /// After Sorting...
        /// A11, A13, B12, B14
        /// </summary>
        public static void SortExample()
        {
            Console.WriteLine("Before Sorting...");
            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine(string.Join(",", pallets));

            Array.Sort(pallets);

            Console.WriteLine("After Sorting...");
            Console.WriteLine(string.Join(",", pallets));
        }

        /// <summary>
        /// Outputs
        /// Before Sorting...
        /// B14,A11,B12,A13
        /// After Reverse Sorting...
        /// A13,B12,A11,B14
        /// </summary>
        public static void ReverseSortExample() {

            Console.WriteLine("Before Sorting...");
            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine(string.Join(",", pallets));

            Array.Reverse(pallets);

            Console.WriteLine("After Reverse Sorting...");
            Console.WriteLine(string.Join(",", pallets));
        }

        /// <summary>
        /// Outputs
        /// Clearing 2 ... count: 4
        /// ,,B12,A13
        /// </summary>
        public static void ClearExample()
        {
            string[] pallets = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("");

            Array.Clear(pallets, 0, 2);
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");

            Console.WriteLine(string.Join(",", pallets));
        }

        /// <summary>
        /// Outputs
        /// B14,A11,B12,A13
        /// Resizing 6 ... count: 6
        /// B14,A11,B12,A13,C01,C02
        /// </summary>
        public static void ResizeAndAdd() {
            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine(string.Join(",", pallets));

            Array.Resize(ref pallets, 6);
            Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            pallets[4] = "C01";
            pallets[5] = "C02";

            Console.WriteLine(string.Join(",", pallets));
        }
    }
}
