using System;
using System.Collections.Generic;

namespace NullCoalescingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Example1();
            Example2();
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
    }
}
