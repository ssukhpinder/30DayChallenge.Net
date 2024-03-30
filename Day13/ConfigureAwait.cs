using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day13
{
    public static class ConfigureAwait
    {
        /// <summary>
        /// Old approach with classic async await 
        /// </summary>
        /// <returns></returns>
        public async static Task OldApproach()
        {
            await ReadDataAsync();
        }

        /// <summary>
        /// Optimized approach with ConfigureAwait
        /// </summary>
        /// <returns></returns>
        public static async Task OptimizedApproachAsync()
        {
            await ReadDataAsync().ConfigureAwait(false);
        }

        public async static Task ReadDataAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine($"Mesaage written after 1 second");
        }
    }
}
