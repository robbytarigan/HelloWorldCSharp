using System;

namespace PositionalRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Mads", "Torgersen"); // positional construction
            var (f, l) = person;
            Console.WriteLine($"f = {f}, l = {l}");

            var personA = new PersonA("Robby", "Tarigan");
            // personA.FirstName; Cannot get protected FirstName

            var student = new Student("Robby", "Tarigan", 17);
            Console.WriteLine(student);
        }
    }

    // This is a positional approach to a record
    /*
    public record Person
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public Person(string firstName, string lastName)
          => (FirstName, LastName) = (firstName, lastName);
        public void Deconstruct(out string firstName, out string lastName)
          => (firstName, lastName) = (FirstName, LastName);
    }
    */

    // This is the shorter syntax
    public record Person(string FirstName, string LastName);

    /**
     * If you don’t like the generated auto-property you can define your own property of the same name instead, and the generated constructor and 
     * deconstructor will just use that one. In this case, the parameter is in scope for you to use for initialization. 
     * Say, for instance, that you’d rather have the FirstName be a protected property:
     */
    public record PersonA(string FirstName, string LastName)
    {
        protected string FirstName { get; init; } = FirstName;
    }

    // A positional record can call a base constructor like this:
    public record Student(string FirstName, string LastName, int ID) : Person(FirstName, LastName);
}
