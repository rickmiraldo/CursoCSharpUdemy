using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharpUdemy.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + " R$ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
