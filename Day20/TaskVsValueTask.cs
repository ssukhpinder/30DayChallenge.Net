using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day20
{
    public static class TaskVsValueTask
    {
        public static async Task<string> FetchDataAsync()
        {
            // Simulate a delay to mimic fetching data
            await Task.Delay(1000);
            return "Data fetched using Task";
        }

        public static async ValueTask<string> FetchDataValueTaskAsync()
        {
            // Simulate a delay to mimic fetching data
            await Task.Delay(1000); // Note: Use Task.Delay for the sake of example.
            return "Data fetched using ValueTask";
        }
    }
}
