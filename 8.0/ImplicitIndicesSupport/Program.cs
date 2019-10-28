using System;

namespace ImplicitIndicesSupport
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

    public class Collection
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

        public int this[int index] => _array[index];
    }

    public class SideEffect
    {
        public Collection Get()
        {
            Console.Write("Get ");
            return new Collection();
        }

        public void Use()
        {
            int i = Get()[^1];
            Console.WriteLine(i);
        }

        public void Use2()
        {
            int i = Get()[^2];
            Console.WriteLine(i);
        }
    }
}
