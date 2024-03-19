using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day2
{
    public static class CodeBlocksAndScope
    {
        /// <summary>
        /// Output
        /// Inside the code block: 10
        /// </summary>
        public static void VariableInCodeBlock()
        {
            bool flag = true;
            if (flag)
            {
                int value = 10;
                Console.WriteLine($"Inside the code block: {value}");
            }
        }

        /// <summary>
        /// Outputs
        /// Program.cs(7,46): error CS0103: The name 'value' does not exist in the current context
        /// </summary>
        public static void VariableOutCodeBlock()
        {
            bool flag = true;
            if (flag)
            {
                int value = 10;
                Console.WriteLine($"Inside the code block: {value}");
            }

            //Uncomment below line to validate
            //Console.WriteLine($"Outside the code block: {value}");
        }

        /// <summary>
        /// Outputs
        /// Program.cs(6,49): error CS0165: Use of unassigned local variable 'value'
        /// </summary>
        public static void VariableAboveCodeBlock()
        {
            bool flag = true;
            int value;

            if (flag)
            {
                //Uncomment below line to validate
                //Console.WriteLine($"Inside the code block: {value}");
            }

            value = 10;
            Console.WriteLine($"Outside the code block: {value}");
        }

        /// <summary>
        /// Outputs
        /// Inside the code block: 0
        /// Outside the code block: 10
        /// </summary>
        /// <returns></returns>
        public static void VariableAboveCodeBlockv1()
        {
            bool flag = true;
            int value = 0;

            if (flag)
            {
                Console.WriteLine($"Inside the code block: {value}");
            }

            value = 10;
            Console.WriteLine($"Outside the code block: {value}");
        }
    }

}
