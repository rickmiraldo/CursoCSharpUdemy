using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpUdemy.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenses { get; set; }

        public Individual(string name, double anualIncome, double healthExpenses) : base(name, anualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double CalculateTax()
        {
            double tax = AnualIncome < 20000.0 ? AnualIncome * 0.15 : AnualIncome * 0.25;
            return tax = HealthExpenses > 0 ? tax - HealthExpenses * 0.5 : tax;
        }
    }
}
