using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person student = new Student { FirstName = "Mads", LastName = "Nielsen", ID = 129 };

            var otherStudent = student with { LastName = "Torgersen" };
            Console.WriteLine(otherStudent is Student); // true

            Person similarStudent = new Student { FirstName = "Mads", LastName = "Nielsen", ID = 130 };
            Console.WriteLine(student != similarStudent); //true, since ID's are different
        }
    }

    public record Person
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }

    public record Student : Person
    {
        public int ID;
    }
}
