using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day19
{
    public static class StackVsHeap
    {
        public static void InefficientMethod(int index)
        {
            // Inefficient: Creates a new string object on the heap
            Console.WriteLine(new string($"User{index}".ToCharArray()));
        }

        public static void EfficientMethod(int index)
        {
            // Efficient: Avoids unnecessary heap allocation
            Console.WriteLine($"User{index}");
        }
    }
}
