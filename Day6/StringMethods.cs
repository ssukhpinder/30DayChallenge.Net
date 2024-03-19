using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day6
{
    public static class StringMethods
    {
        /// <summary>
        /// Outputs
        /// 13
        /// 36
        /// </summary>
        public static void IndexOfExample()
        {
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            Console.WriteLine(openingPosition);
            Console.WriteLine(closingPosition);
        }

        /// <summary>
        /// Outputs
        /// (inside the parentheses
        /// </summary>
        public static void SubstringExample()
        {
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        }

        /// <summary>
        /// Outputs
        /// inside the parentheses
        /// </summary>
        public static void SubstringExample2()
        {
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            openingPosition += 1;

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        }
    }
}
