using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day10
{
    public static class FilePath
    {
        /// <summary>
        /// Outputs
        /// D:\Workspace\30DayChallenge.Net\30DayChallenge.Net\bin\Debug\net8.0
        /// </summary>
        public static void DisplayCurrentDirectory()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
        }

        /// <summary>
        /// Outputs
        /// C:\Users\admin\Documents
        /// </summary>
        public static void DisplaySpecialDirectory()
        {
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }

        /// <summary>
        /// Outputs
        /// For windows: \sample        
        /// </summary>
        public static void DisplayOSPathCharacters()
        {
            Console.WriteLine($"For windows: {Path.DirectorySeparatorChar}sample");
        }

        /// <summary>
        /// Outputs
        /// .json
        /// </summary>
        public static void DisplayFileExtension()
        {
            Console.WriteLine(Path.GetExtension("sample.json"));
        }
    }
}
