using System;
using System.Threading.Tasks;

namespace Discards
{
    class Program
    {

        public static void Main()
        {
            ExecuteAsyncMethods().Wait();
        }

        private static async Task ExecuteAsyncMethods()
        {
            Console.WriteLine("About to launch a task...");
            _ = Task.Run(() =>
            {
                var iterations = 0;
                for (int ctr = 0; ctr < int.MaxValue; ctr++)
                    iterations++;
                Console.WriteLine("Completed looping operation...");
                throw new InvalidOperationException();
            });
            await Task.Delay(7000);
            Console.WriteLine("Exiting after 7 second delay");
        }

    }
}
