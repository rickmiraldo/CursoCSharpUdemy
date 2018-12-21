using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using CursoCSharpUdemy.Entities;
using System.Linq;

namespace CursoCSharpUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string filePath = Console.ReadLine();

            List<Employee> employees = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salaryValue = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        employees.Add(new Employee(name, email, salaryValue));
                    }
                }

                Console.Write("Enter salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Email of people whose salary is more than " + salary.ToString("F2", CultureInfo.InvariantCulture) + ":");
                var emails = employees.Where(e => e.Salary > salary).OrderBy(e => e.Name).Select(e => e.Email);
                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }

                Console.Write("Sum of salary of people whose name starts with 'M': ");
                var sum = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
                Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
