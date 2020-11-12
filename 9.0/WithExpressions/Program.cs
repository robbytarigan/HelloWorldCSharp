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

            var originalPerson = otherPerson with { LastName = "Nielsen" };
            Console.WriteLine($"ReferenceEquals(person, originalPerson) = {object.ReferenceEquals(person, originalPerson)}");
            Console.WriteLine($"Equals(person, originalPerson) = {object.Equals(person, originalPerson)}");
        }

        public record Person(string FirstName, string LastName);
    }
}
