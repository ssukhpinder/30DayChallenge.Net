using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DayChallenge.Net.Day22
{
    public static class ArrayPoolExample
    {
        public static void BadMethod()
        {
            // Allocating a new large buffer
            byte[] buffer = new byte[4096];
            // Simulate work with the buffer
            FillBuffer(buffer, 0xAA); // Example operation
            Console.WriteLine("Buffer used and will be discarded after method execution.");
        }

        public static void GoodMethod()
        {
            var pool = ArrayPool<byte>.Shared;
            byte[] buffer = pool.Rent(4096);
            try
            {
                // Work with the buffer
                FillBuffer(buffer, 0xBB); // Example operation
                Console.WriteLine("Buffer rented from the pool and returned after use.");
            }
            finally
            {
                pool.Return(buffer);
            }
        }

        public static void FillBuffer(byte[] buffer, byte value)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = value;
            }
            // Just an example to simulate buffer usage
            Console.WriteLine($"Buffer filled with value: {value}");
        }
    }
}
