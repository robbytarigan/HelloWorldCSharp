using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldCSharp6
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            var product = new Product("Car", "  Should be without space. right.  ");

            Console.WriteLine(product.GetLongDescription());

            Console.ReadLine();
        }
    }
}
