using System;

namespace RefLocals
{
    class Program
    {
        private static int[] _array =  { 1, 42, 23, 5 };

        public static ref int ArrayValue(int index)
        {
            return ref _array[index];
        }

        static void Main()
        {
            ref var val = ref ArrayValue(1);
            val++;
            // Print: 1,43,23,5
            Console.WriteLine(string.Join(",", _array));
        }
    }
}
