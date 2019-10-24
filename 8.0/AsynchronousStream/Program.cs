using System;
using System.Threading.Tasks;

namespace AsynchronousStream
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await foreach (var number in GenerateSequence())
            {
                Console.WriteLine(number);
            }
        }

        public static async System.Collections.Generic.IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(500);
                yield return i;
            }
        }
    }
}
