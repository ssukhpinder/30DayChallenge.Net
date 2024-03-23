using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day5
{
    public static class WhileLoop
    {
        /// <summary>
        /// Outputs
        /// 2
        /// 5
        /// 8
        /// 2
        /// 7
        /// </summary>
        public static void DoWhileLoopExample()
        {
            Random random = new Random();
            int current = 0;

            do
            {
                current = random.Next(1, 11);
                Console.WriteLine(current);
            } while (current != 7);
        }

        /// <summary>
        /// Outputs
        /// 9
        /// 7
        /// 5
        /// Last number: 1
        /// </summary>
        public static void WhileLoopExample()
        {
            Random random = new Random();
            int current = random.Next(1, 11);

            while (current >= 3)
            {
                Console.WriteLine(current);
                current = random.Next(1, 11);
            }
            Console.WriteLine($"Last number: {current}");
        }

        /// <summary>
        /// Outputs
        /// 5
        /// 1
        /// 6
        /// 7
        /// </summary>
        public static void ContinueDoWhileLoopExample()
        {
            Random random = new Random();
            int current = random.Next(1, 11);

            do
            {
                current = random.Next(1, 11);

                if (current >= 8) continue;

                Console.WriteLine(current);
            } while (current != 7);
        }
    }
}
