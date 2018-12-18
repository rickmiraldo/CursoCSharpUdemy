using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpUdemy.Services
{
    class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            return (amount <= 100) ? amount * 0.2 : amount * 0.15;
        }
    }
}
