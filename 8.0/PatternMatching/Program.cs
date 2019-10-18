using System;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Switch Expression Example {0}", SwitchExpression.FromRainbow(Rainbow.Violet));

            Console.WriteLine("Property Pattern Example {0}", PropertyPattern.ComputeSalesTax(new Address { State = "MI"}, 2M));
        }       
    }
}
