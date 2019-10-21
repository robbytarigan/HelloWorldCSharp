using System;

namespace StaticLocalFunction
{
    class Program
    {
        private static int NonStaticLocal()
        {
            int y;
            LocalFunction();
            return y;

            void LocalFunction() => y = 0;
        }

        private static int StaticLocal()
        {
            int y = 5;
            int x = 7;
            return Add(x, y);

            static int Add(int left, int right) => left + right;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Non Static Local Function call {0}", NonStaticLocal());
            Console.WriteLine("Static Local Function call {0}", StaticLocal());
        }
    }
}
