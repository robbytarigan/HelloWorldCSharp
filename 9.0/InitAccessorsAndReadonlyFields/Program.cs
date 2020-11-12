using System;

namespace InitAccessorsAndReadonlyFields
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { FirstName = "Robby", LastName = "Tarigan" };

            Console.WriteLine($"{person.FirstName} {person.LastName}");

            // person.FirstName = "Mads"; This is error
        }

        public class Person
        {
            private readonly string firstName = "<unknown>";
            private readonly string lastName = "<unknown>";

            public string FirstName
            {
                get => firstName;
                init => firstName = (value ?? throw new ArgumentNullException(nameof(FirstName)));
            }
            public string LastName
            {
                get => lastName;
                init => lastName = (value ?? throw new ArgumentNullException(nameof(LastName)));
            }
        }
    }
}
