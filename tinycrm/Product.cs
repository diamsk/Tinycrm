using System;
using System.Collections.Generic;
using System.Text;

namespace tinycrm
{
    public class Product
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public decimal Price { get; private set; }

        public Product(decimal randomPrice)
        {
            
            Price = randomPrice;
        }

    }
}
