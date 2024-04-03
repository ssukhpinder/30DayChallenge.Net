using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day17
{
    public static class IncrementClass
    {
        private static int _counter = 0;

        /// <summary>
        /// Outputs
        /// Counter value: 10
        /// </summary>
        public static void TestIncrementCounter()
        {
            // Create an array to hold the tasks
            Task[] tasks = new Task[10];

            // Initialize and start tasks
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() => IncrementCounter());
            }

            // Wait for all tasks to complete
            Task.WaitAll(tasks);

            Console.WriteLine($"Counter value: {_counter}");
        }
        public static void IncrementCounter()
        {
            // Safely increment the counter across multiple threads
            Interlocked.Increment(ref _counter);
        }
    }
}
