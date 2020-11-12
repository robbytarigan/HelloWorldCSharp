using System;

namespace Records
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person { FirstName = "Robby", LastName = "Tarigan" };
            var person2 = new Person { FirstName = "Robby", LastName = "Tarigan" };

            Console.WriteLine($"person1 == person2 is {person1 == person2}");
        }
    }

    public record Person
    {
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
    }
}
