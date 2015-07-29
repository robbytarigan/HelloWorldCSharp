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

            Console.WriteLine("Product name : {0}, description : {1}", product.Name, product.Description);

            Console.ReadLine();
        }
    }
}
