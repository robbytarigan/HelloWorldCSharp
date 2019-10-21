using System;

namespace DisposableRefStruct
{
    class Program
    {
        ref struct Book
        {
            private readonly int id;

            public Book(int id)
            {
                this.id = id;
            }

            public void Dispose()
            {
                Console.WriteLine("Dispose Book {0}", id);
            }
        }

        static void Main(string[] args)
        {
            using var book = new Book(100);
        }
    }
}
