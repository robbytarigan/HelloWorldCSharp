using System;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        // Feature: Async Main
        static async Task<int> Main(string[] args)
        {
            return await Delay(2);
        }

        private static async Task<int> Delay(int value) {
            Console.WriteLine($"Delay for {value} seconds ...");

            await Task.Delay(value * 1000);

            Console.WriteLine($"Returning ...");
            return value;
        }
    }
}
