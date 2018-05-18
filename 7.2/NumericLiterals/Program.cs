using System;

namespace NumericLiterals
{
    class Program
    {
        static void Main(string[] args)
        {
            var byteValue1 = 0b1111_0000;
            
            // Underscore can be added as first character
            var byteValue2 = 0b_1111_0000;
            Console.WriteLine("Number1 = {0}, Number2 = {1}", byteValue1, byteValue2);
        }
    }
}
