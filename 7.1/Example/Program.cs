using System;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        // Feature: Async Main
        static async Task<int> Main(string[] args)
        {
            DefaultExample();
            InferredTuppleExample();
            return await Delay(2);
        }

        private static async Task<int> Delay(int value) {
            Console.WriteLine($"Delay for {value} seconds ...");

            await Task.Delay(value * 1000);

            Console.WriteLine($"Returning ...");
            return value;
        }

        private static void DefaultExample() {
            // Feature: Default literal Expressions
           Func<string, bool> expression = default;

           Console.WriteLine(expression == null);
        }

        private static void InferredTuppleExample() {
            int count = 5;
            string label = "Colours used in the map";
            // Feature: Inferred tupple element names
            var pair = (count, label);

            Console.WriteLine($"count = {pair.count}, label = {pair.label}");
        }
    }
}
