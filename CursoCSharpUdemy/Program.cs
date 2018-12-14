using System;
using System.Globalization;
using System.Collections.Generic;
using CursoCSharpUdemy.Entities;

namespace CursoCSharpUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nProduct #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customs));
                } else if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, date));
                } else
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
