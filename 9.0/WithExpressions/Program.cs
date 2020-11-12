using System;

namespace WithExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Mads", "Nielsen");
            var otherPerson = person with { LastName = "Torgersen" };

            Console.WriteLine($"person is {person}");
            Console.WriteLine($"otherPerson is {otherPerson}");
        }

        public record Person(string FirstName, string LastName);
    }
}
