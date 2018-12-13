using System;
using System.Globalization;
using System.Collections.Generic;
using CursoCSharpUdemy.Entities;
using CursoCSharpUdemy.Entities.Enums;

namespace CursoCSharpUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("\nEnter order data:");
            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int itemQtty = int.Parse(Console.ReadLine());

            for (int i = 1; i <= itemQtty; i++)
            {
                Console.WriteLine("\nEnter #" + i + " item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int productQtty = int.Parse(Console.ReadLine());

                OrderItem item = new OrderItem(product, productQtty);
                order.AddOrderItem(item);
            }

            Console.WriteLine("\nORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
