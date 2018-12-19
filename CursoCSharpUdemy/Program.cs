using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using CursoCSharpUdemy.Entities;
using CursoCSharpUdemy.Services;

namespace CursoCSharpUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (DD/MM/YYYY): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);
            ContractService contractService = new ContractService(new PayPalService());

            contractService.ProcessContract(contract, installments);

            Console.WriteLine("\nINSTALLMENTS:");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
