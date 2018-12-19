using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharpUdemy.Entities
{
    class Installment
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime date, double amount)
        {
            Date = date;
            Amount = amount;
        }

        public override string ToString()
        {
            return Date.ToShortDateString() + " - " + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
