using System;

namespace CovariantReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Animal t = new Tiger();

            Console.WriteLine(t.GetFood());
        }
    }

    abstract class Animal
    {
        public abstract Food GetFood();
    }

    class Tiger : Animal
    {
        public override Meat GetFood() => new();
    }

    public class Food { }

    public class Meat : Food {}
}
