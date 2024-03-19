using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day4
{
    public static class ForLoops
    {
        /// <summary>
        /// Outputs
        /// 0
        /// 1
        /// 2
        /// 3
        /// 4
        /// 5
        /// 6
        /// 7
        /// 8
        /// 9
        /// </summary>
        public static void ForLoopExample()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Outputs
        /// 10
        /// 9
        /// 8
        /// 7
        /// 6
        /// 5
        /// 4
        /// 3
        /// 2
        /// 1
        /// 0
        /// </summary>
        public static void BackwardForLoopExample()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Outputs
        /// 3
        /// 6
        /// 0
        /// 9
        /// </summary>
        public static void IterationForLoopExample()
        {
            for (int i = 0; i < 10; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Outputs
        /// 0
        /// 1
        /// 2
        /// 3
        /// 4
        /// 5
        /// 6
        /// 7
        /// </summary>
        public static void BreakForLoopExample()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7) break;
            }
        }
    }
}
