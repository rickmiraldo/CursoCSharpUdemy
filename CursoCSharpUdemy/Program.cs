using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using CursoCSharpUdemy.Entities;

namespace CursoCSharpUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Full path of original CSV file: ");
            string originalFilePath = Console.ReadLine();

            List<Product> products = new List<Product>();

            try
            {
                string[] lines = File.ReadAllLines(originalFilePath);
                foreach (string l in lines)
                {
                    string[] fields = l.Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1],CultureInfo.InvariantCulture);
                    int quantity = int.Parse(fields[2]);
                    products.Add(new Product(name, price, quantity));
                }

                string workingDirectory = Path.GetDirectoryName(originalFilePath);
                Directory.CreateDirectory(workingDirectory + @"\out");
                string outputFilePath = workingDirectory + @"\out\summary.csv";

                using (FileStream fs = new FileStream(outputFilePath, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        foreach (Product p in products)
                        {
                            sw.WriteLine(p.Name + "," + p.GetTotal().ToString("F2",CultureInfo.InvariantCulture));
                        }
                    }
                }

            }
            catch (IOException e)
            {
                Console.Write("An error has occurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
