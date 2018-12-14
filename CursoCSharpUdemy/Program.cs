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
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int nEmp = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nEmp; i++)
            {
                Console.WriteLine("\nEmployee #" + i + " data:");
                Console.Write("Outsourced? (y/n): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double adCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, value, adCharge));
                } else
                {
                    employees.Add(new Employee(name, hours, value));
                }
            }

            Console.WriteLine("\nPAYMENTS:");
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.Name + " - R$ " + e.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
