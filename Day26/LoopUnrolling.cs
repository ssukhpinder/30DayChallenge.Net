using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day26
{
    public static class LoopUnrolling
    {
        public static void BadWay() {
            const int size = 1024;
            int[] numbers = new int[size];

            // Traditional loop
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * 2;
            }
            watch.Stop();
            Console.WriteLine($"Traditional loop time: {watch.ElapsedTicks} ticks");

        }
        public static void GoodWay()
        {
            const int size = 1024;
            int[] numbers = new int[size];
            int len = numbers.Length;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < len; i += 4)
            {
                numbers[i] = i * 2;
                if (i + 1 < len) numbers[i + 1] = (i + 1) * 2;
                if (i + 2 < len) numbers[i + 2] = (i + 2) * 2;
                if (i + 3 < len) numbers[i + 3] = (i + 3) * 2;
            }
            watch.Stop();
            Console.WriteLine($"Unrolled loop time: {watch.ElapsedTicks} ticks");
        }
    }
}
