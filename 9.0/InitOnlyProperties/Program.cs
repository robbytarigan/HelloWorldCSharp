using System;

namespace InitOnlyProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { FirstName = "Mads", LastName = "Nielsen" }; // OK
            // person.LastName = "Torgersen"; // ERROR!
        }
    }

    public class Person
    {
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
    }
}
