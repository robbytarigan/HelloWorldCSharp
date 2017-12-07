using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace HelloWorldCSharp6
{
    public class Program
    {
        public async Task Main(string[] args)
        {
            WriteLine("Hello world!");
            var product = new Product("Car", "  Should be without space. right 2.  ");

            WriteLine(product.GetLongDescription());

            var viewingDatesProduct = new Product()
            {
                [0] = new DateTime(2015, 7, 29),
                [2] = new DateTime(2015, 8, 1),
                Version = "1.0.1"
            };

            WriteLine($"Viewing dates for version {viewingDatesProduct.Version} are {viewingDatesProduct[0]:dd/MM/yyyy} and {viewingDatesProduct[2]:dd/MM/yyyy}.");

            // Exception filters demo
            try
            {
                throw new Exception("E2");
            }
            catch (Exception ex) when (ex.Message == "E1")
            {
                WriteLine("caught E1");
            }
            catch (Exception ex) when (ex.Message == "E2")
            {
                WriteLine("caught E2");
            }
            
            // Await in catch and finally demo
            try {
                await TaskThatReturnException();
            } catch (Exception ex) {
                await HandleException(ex);
            } finally {
                await FinallyMethod();
            }
                
                
            ReadLine();
        }
        
        public Task TaskThatReturnException()   {
            throw new Exception("Some exception in the task");
        }
        
        public Task<int> HandleException(Exception ex)   {
            Console.WriteLine($"Exception is handled. Error message was {ex.Message}");
            return Task.FromResult(0);
        }
        
        public Task FinallyMethod() {
            Console.WriteLine("Finally awaitable... nice.");
            return Task.FromResult(0);
        }
    }
}
