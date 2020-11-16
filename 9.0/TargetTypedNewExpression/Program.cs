using System;

namespace TargetTypedNewExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new (3, 5);

            Point[] ps = { new (1, 2), new (5, 2), new (5, -3), new (1, -3) }; 

            Console.WriteLine(p);
            Console.WriteLine(ps);
        }
    }

    public record Point(int X, int Y);
}
