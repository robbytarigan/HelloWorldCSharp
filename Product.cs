using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldCSharp6
{
    public class Product
    {
        private readonly string name;

        private readonly int version;

        private readonly string description;

        public Product(string name, string description)
        {


            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(Product));
            }

            this.name = name;
            this.description = description?.Trim();
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }
    }
}
