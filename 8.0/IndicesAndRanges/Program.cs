using System;
using System.Linq;

namespace IndicesAndRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };              // 9 (or words.Length) ^0

            Console.WriteLine($"The last word is {words[^1]}");
            
            string[] quickBrownFox = words[1..4];
            foreach (var word in quickBrownFox)
                Console.Write($"< {word} >");
            Console.WriteLine();

            string[] lazyDog = words[^2..^0];
            foreach (var word in lazyDog)
                Console.Write($"< {word} >");
            Console.WriteLine();

            string[] allWords = words[..]; // contains "The" through "dog".
            string[] firstPhrase = words[..4]; // contains "The" through "fox"
            string[] lastPhrase = words[6..]; // contains "the, "lazy" and "dog"
            foreach (var word in allWords)
                Console.Write($"< {word} >");
            Console.WriteLine();
            foreach (var word in firstPhrase)
                Console.Write($"< {word} >");
            Console.WriteLine();
            foreach (var word in lastPhrase)
                Console.Write($"< {word} >");
            Console.WriteLine();

            Index the = ^3;
            Console.WriteLine(words[the]);
            Range phrase = 1..4;
            string[] text = words[phrase];
            foreach (var word in text)
                Console.Write($"< {word} >");
            Console.WriteLine();

            SpanExample();
        }

        private static void SpanExample() {
            int[] numbers = Enumerable.Range(0, 100).ToArray();
            int x = 12;
            int y = 25;
            int z = 36;

            Console.WriteLine($"{numbers[^x]} is the same as {numbers[numbers.Length - x]}");
            Console.WriteLine($"{numbers[x..y].Length} is the same as {y - x}");

            Console.WriteLine("numbers[x..y] and numbers[y..z] are consecutive and disjoint:");
            Span<int> x_y = numbers[x..y];
            Span<int> y_z = numbers[y..z];
            Console.WriteLine($"\tnumbers[x..y] is {x_y[0]} through {x_y[^1]}, numbers[y..z] is {y_z[0]} through {y_z[^1]}");

            Console.WriteLine("numbers[x..^x] removes x elements at each end:");
            Span<int> x_x = numbers[x..^x];
            Console.WriteLine($"\tnumbers[x..^x] starts with {x_x[0]} and ends with {x_x[^1]}");

            Console.WriteLine("numbers[..x] means numbers[0..x] and numbers[x..] means numbers[x..^0]");
            Span<int> start_x = numbers[..x];
            Span<int> zero_x = numbers[0..x];
            Console.WriteLine($"\t{start_x[0]}..{start_x[^1]} is the same as {zero_x[0]}..{zero_x[^1]}");
            Span<int> z_end = numbers[z..];
            Span<int> z_zero = numbers[z..^0];
            Console.WriteLine($"\t{z_end[0]}..{z_end[^1]} is the same as {z_zero[0]}..{z_zero[^1]}");
        }
    }
}
