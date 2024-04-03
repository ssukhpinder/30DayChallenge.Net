using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day19
{
    public static class StackVsHeap
    {
        public static string InefficientMethod(int index)
        {
            // Inefficient: Creates a new string object on the heap
            return new string($"User{index}".ToCharArray());
        }

        public static string EfficientMethod(int index)
        {
            // Efficient: Avoids unnecessary heap allocation
            return $"User{index}";
        }
    }
}
