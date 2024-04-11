using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day25
{
    public static class ExceptionFilters
    {
        public static void MultipleCatch(string input)
        {
            try
            {
                ProcessInput(input);
            }
            catch (Exception ex)
            {
                if (ex is InvalidOperationException || ex is ArgumentNullException)
                {
                    Console.WriteLine($"Conventional Handling: Caught {ex.GetType().Name}");
                }
                else
                {
                    throw;
                }
            }
        }
        public static void GoodWay(string input)
        {
            // Using exception filters
            try
            {
                ProcessInput(input);
            }
            catch (Exception ex) when (ex is InvalidOperationException || ex is ArgumentNullException)
            {
                Console.WriteLine($"Exception Filters Handling: Caught {ex.GetType().Name}");
            }
        }

        public static void ProcessInput(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input), "Input cannot be null.");
            else if (input == "invalid")
                throw new InvalidOperationException("Invalid input provided.");

            Console.WriteLine($"Processing {input}");
        }
    }
}
