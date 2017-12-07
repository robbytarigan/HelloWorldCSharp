using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldCSharp6
{
    public class Product
    {
        private readonly IDictionary<int, DateTime> viewingDates;
        
        public Product(string name, string description)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(Product));
            }

            this.Name = name;
            this.Description = description?.Trim();            
        }

        public Product()    {
            this.viewingDates = new Dictionary<int, DateTime>();
        }

        public DateTime this[int index] 
        { 
            get 
            {
                return this.viewingDates[index];
            }
            
            set 
            {
                this.viewingDates[index] = value;
            }
        }

        public string Name { get; }
        
        public string Version { get; set; } = "1.0.0";
        
        public string Description { get; }               
        
        public string GetLongDescription() => $"Product Name 1: {Name}, Version: {Version} Description : {Description}"; 
    }
}
