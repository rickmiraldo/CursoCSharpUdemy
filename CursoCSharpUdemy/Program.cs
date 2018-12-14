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
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nTax payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Individual expenditures: ");
                    double exp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, income, exp));
                } else
                {
                    Console.Write("Number of employees: ");
                    int emp = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, income, emp));
                }
            }

            Console.WriteLine("\nTAXES PAID;");
            double sum = 0.0;
            foreach (TaxPayer tp in taxPayers)
            {
                Console.WriteLine(tp.Name + ": R$ " + tp.CalculateTax().ToString("F2",CultureInfo.InvariantCulture));
                sum += tp.CalculateTax();
            }

            Console.WriteLine("\nTOTAL TAXES: R$ " + sum.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
