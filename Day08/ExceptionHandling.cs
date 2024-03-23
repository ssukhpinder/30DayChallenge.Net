using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day8
{
    public static class ExceptionHandling
    {
        /// <summary>
        /// Outputs
        /// Hello from try block
        /// Hello from exception block
        /// Hello from finally block
        /// </summary>
        public static void SimpleExceptionBlock()
        {
            try
            {
                // try code block - code that may generate an exception
                Console.WriteLine("Hello from try block");
                throw new NotImplementedException();
            }
            catch
            {
                // catch code block - code to handle an exception
                Console.WriteLine("Hello from exception block");
            }
            finally
            {
                // finally code block - code to clean up resources
                Console.WriteLine("Hello from finally block");
            }
        }

        /// <summary>
        /// Outputs
        /// Hello from try block
        /// Hello from inner finally block
        /// Hello from exception block
        /// Hello from outer finally block
        /// </summary>
        public static void NestedExceptionBlock()
        {
            try
            {
                // Step 1: code execution begins
                try
                {
                    // Step 2: an exception occurs here
                    Console.WriteLine("Hello from try block");
                    throw new NotImplementedException();
                }
                finally
                {
                    // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
                    Console.WriteLine("Hello from inner finally block");
                }

            }
            catch // Step 3: the system finds a catch clause that can handle the exception
            {
                // Step 5: the system transfers control to the first line of the catch code block
                Console.WriteLine("Hello from exception block");
            }
            finally
            {
                Console.WriteLine("Hello from outer finally block");
            }
        }
    }
}
