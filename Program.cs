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

            var viewingDatesProduct = new Product()
            {
                [0] = new DateTime(2015, 7, 29),
                [2] = new DateTime(2015, 8, 1),
                Version = "1.0.1"
            };

            Console.WriteLine($"Viewing dates for version {viewingDatesProduct.Version} are {viewingDatesProduct[0]:dd/MM/yyyy} and {viewingDatesProduct[2]:dd/MM/yyyy}.");

            // Exception filters demo
            try
            {
                throw new Exception("E2");
            }
            catch (Exception ex) when (ex.Message == "E1")
            {
                Console.WriteLine("caught E1");
            }
            catch (Exception ex) when (ex.Message == "E2")
            {
                Console.WriteLine("caught E2");
            }

            Console.ReadLine();
        }
    }
}
