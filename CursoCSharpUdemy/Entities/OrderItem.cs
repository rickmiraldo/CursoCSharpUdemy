using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharpUdemy.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
            Price = product.Price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name + ", R$ " + Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: " + Quantity + ", Subtotal: R$ " + SubTotal().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
