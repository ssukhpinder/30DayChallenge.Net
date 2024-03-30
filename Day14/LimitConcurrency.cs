using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day14
{
    public static class LimitConcurrency
    {
        /// <summary>
        /// Old approach with classic async await 
        /// </summary>
        /// <returns></returns>
        public async static Task OldApproach(List<string> items)
        {
            var tasks = items.Select(async item => await ProcessItem(item));
            await Task.WhenAll(tasks);
        }


        /// <summary>
        /// Optimized approach with limit concurrency
        /// </summary>
        /// <returns></returns>
        public static async Task OptimizedApproachAsync(List<string> items, int maxConcurrency = 10)
        {
            using (var semaphore = new SemaphoreSlim(maxConcurrency))
            {
                var tasks = items.Select(async item =>
                {
                    await semaphore.WaitAsync(); // Limit concurrency by waiting for the semaphore.
                    try
                    {
                        await ProcessItem(item);
                    }
                    finally
                    {
                        semaphore.Release(); // Release the semaphore to allow other operations.
                    }
                });

                await Task.WhenAll(tasks);
            }
        }

        private static async Task ProcessItem(object item)
        {
            throw new NotImplementedException();
        }
    }
}
