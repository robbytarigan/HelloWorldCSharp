using System;

namespace ImplicitRangesSupport
{
    class Program
    {
        static void Main(string[] args)
        {
            var effect = new SideEffect();
            effect.Use();
            effect.Use2();
        }

    }
    class Collection
    {
        private int[] _array = new[] { 1, 2, 3 };

        public int Length
        {
            get
            {
                Console.Write("Length ");
                return _array.Length;
            }
        }

        public int[] Slice(int start, int length)
        {
            var slice = new int[length];
            Array.Copy(_array, start, slice, 0, length);
            return slice;
        }
    }

    class SideEffect
    {
        public Collection Get()
        {
            Console.Write("Get ");
            return new Collection();
        }

        public void Use()
        {
            var array = Get()[0..2];
            Console.WriteLine(array.Length);
        }

        public void Use2()
        {
            var array = Get()[..];
            Console.WriteLine(array.Length);
        }
    }
}
