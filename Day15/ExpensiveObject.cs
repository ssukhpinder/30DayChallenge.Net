using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day15
{
    public class ExpensiveObject
    {
        public ExpensiveObject()
        {
            Console.WriteLine("Initializing expensive resource... This might take a while.");
            // Simulating expensive initialization with a delay
            Thread.Sleep(2000); // Delay for 2 seconds
            Console.WriteLine("Expensive resource initialized!");
        }

        public void UseResource()
        {
            Console.WriteLine("Using the expensive resource.");
        }
    }
}
