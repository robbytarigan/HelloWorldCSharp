using System;

namespace UnmanagedTypes
{
    class Program
    {
        public struct Coords<T>
        {
            public T X;
            public T Y;
        }

        static void Main(string[] args)
        {
            Span<Coords<int>> coordinates = stackalloc[]
            {
                new Coords<int> { X = 0, Y = 0 },
                new Coords<int> { X = 0, Y = 3 },
                new Coords<int> { X = 4, Y = 0 }
            };

            foreach (var c in coordinates) {
                Console.WriteLine("{{ X = {0}, Y = {1} }}",c.X, c.Y);
            }
        }
    }
}
