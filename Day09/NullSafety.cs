using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day9
{
    record TestRecord(int Id, string Name);
    public static class NullSafety
    {
        /// <summary>
        /// The method will throw System.NullReferenceException
        /// </summary>
        public static void Unsafe()
        {
            try
            {
                TestRecord records = null;

                _ = records.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Method shows extra if condition to validate nullability
        /// </summary>
        public static void SafeExample()
        {
            TestRecord records = null;

            // Check for null
            if (records is not null)
            {
                _ = records.ToString();
            }
        }
    }
}
