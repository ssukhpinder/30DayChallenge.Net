using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day28
{
    public static class StackAlloc
    {
        static int count = 10000;  // Number of elements
        static double[] values = new double[count];
        public static void BadWay() {

            FillValues(values);
            // Calculate sum using heap allocation

            double heapSum = CalculateSumHeap(values);
            Console.WriteLine($"Heap allocation sum: {heapSum}");

        }
        public static void GoodWay()
        {

            FillValues(values);

            // Calculate sum using stackalloc
            double stackSum = CalculateSumStackalloc(count);
            Console.WriteLine($"Stackalloc sum: {stackSum}");
        }
        private static void FillValues(double[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = SomeValue(i);
            }
        }

        private static double SomeValue(int i)
        {
            // Just a sample value function
            return i * 2.5;
        }

        private static double CalculateSumHeap(double[] values)
        {
            double sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum;
        }

        private static unsafe double CalculateSumStackalloc(int count)
        {
            double sum = 0;
            double* values = stackalloc double[count];
            for (int i = 0; i < count; i++)
            {
                values[i] = SomeValue(i);
                sum += values[i];
            }
            return sum;
        }
    }
}
