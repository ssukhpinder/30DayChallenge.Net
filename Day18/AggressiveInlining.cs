using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day18
{
    public static class AggressiveInlining
    {
        public static int MultiplyByTwo(int value)
        {
            return value * 2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MultiplyByTwoWithAggressiveInlining(int value)
        {
            return value * 2;
        }
    }
}
