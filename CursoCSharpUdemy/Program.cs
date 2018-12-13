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
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // Upcasting
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // Downcasting
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            // BusinessAccount acc5 = (BusinessAccount)acc3; -- Erro em tempo de execução!
            if (acc3 is BusinessAccount)
            {
                // BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; // Sintaxe alternativa
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if (acc3 is SavingsAccount)
            {
                // SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount; // Sintaxe alternativa
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
