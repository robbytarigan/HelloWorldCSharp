using System;
using System.Collections.Generic;
using System.Linq;

namespace NullCoalescingAssignment
{
    class Program
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value), "Name cannot be null");
        }

        static void Main(string[] args)
        {
            Example1();
            Example2();
            AlternativeExpressionExample();
            ProvideValueOfUnderlyingTypeExample();
        }

        private static void Example1()
        {
            Console.WriteLine("---------------------- Example 1 -----------------------------");
            List<int> numbers = null;
            int? i = null;

            numbers ??= new List<int>();
            numbers.Add(i ??= 17);
            numbers.Add(i ??= 20);

            Console.WriteLine(string.Join(" ", numbers));  // output: 17 17
            Console.WriteLine(i);  // output: 17
        }

        private static void Example2()
        {
            Console.WriteLine("---------------------- Example 2 -----------------------------");
            List<int> numbers = null;
            int? a = null;

            (numbers ??= new List<int>()).Add(5);
            Console.WriteLine(string.Join(" ", numbers));  // output: 5

            numbers.Add(a ??= 0);
            Console.WriteLine(string.Join(" ", numbers));  // output: 5 0
            Console.WriteLine(a);  // output: 0
        }
        private static void Display<T>(T a, T backup)
        {
            Console.WriteLine(a ?? backup);
        }

        private static void AlternativeExpressionExample()
        {
            Console.WriteLine("----------------------Alternative Expression Example -----------------------------");
            double SumNumbers(List<double[]> setsOfNumbers, int indexOfSetToSum)
            {
                return setsOfNumbers?[indexOfSetToSum]?.Sum() ?? double.NaN;
            }

            var sum = SumNumbers(null, 0);
            Console.WriteLine(sum);  // output: NaN
        }

        private static void ProvideValueOfUnderlyingTypeExample()
        {
            Console.WriteLine("---------------------- Provide Value of Underlying Type Example -----------------------------");
            int? a = null;
            int b = a ?? -1;
            Console.WriteLine(b);  // output: -1
        }
    }
}
