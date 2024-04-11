using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day23
{
    public static class SpanOverArray
    {
        public static void ProcessData(byte[] data)
        {
            Console.WriteLine("Processing byte array:");
            foreach (var b in data)
            {
                Console.Write($"{b} ");
            }
            Console.WriteLine("\n");
        }

        public static void ProcessData(Span<byte> dataSpan)
        {
            Console.WriteLine("Processing Span<byte>:");
            foreach (var b in dataSpan)
            {
                Console.Write($"{b} ");
            }
            Console.WriteLine("\n");
        }
    }
}
