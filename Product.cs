using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldCSharp6
{
    public class Product
    {
        public Product(string name, string description)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(Product));
            }

            this.Name = name;
            this.Description = description?.Trim();
        }

        public string Name { get; }
        
        public string Version { get; } = "1.0.0";
        
        public string Description { get; }               
        
        public string GetLongDescription() => $"Product Name 1: {Name}, Version: {Version} Description : {Description}"; 
    }
}
