using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day3
{
    public static class Switch
    {
        static int employeeLevel = 200;
        static string employeeName = "John Smith";

        /// <summary>
        /// Outputs
        /// John Smith, Senior Associate
        /// </summary>
        public static void SwitchExample()
        {
            string title = "";

            switch (employeeLevel)
            {
                case 100:
                    title = "Junior Associate";
                    break;
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }

            Console.WriteLine($"{employeeName}, {title}");
        }

        /// <summary>
        /// John Smith, Associate
        /// </summary>
        public static void ChangeSwitchLabelExample()
        {
            employeeLevel = 201;
            SwitchExample();
        }

        /// <summary>
        /// Outputs
        /// John Smith, Senior Associate
        /// </summary>
        public static void MultipleSwitchLabelExample()
        {
            int employeeLevel = 100;
            string employeeName = "John Smith";

            string title = "";

            switch (employeeLevel)
            {
                case 100:
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }

            Console.WriteLine($"{employeeName}, {title}");
        }
    }
}
