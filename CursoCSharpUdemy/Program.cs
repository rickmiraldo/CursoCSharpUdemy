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
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nShape #{i} data:");
                Console.Write("Rectangle ot Circle (r/c): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double w = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(w, h, color));
                } else
                {
                    Console.Write("Radius: ");
                    double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(r, color));
                }
            }

            Console.WriteLine("\nSHAPE AREAS:");
            foreach (Shape s in shapes)
            {
                Console.WriteLine(s.Area().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
