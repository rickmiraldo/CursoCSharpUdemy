using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharpUdemy.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return Name + " R$ " + (Price + CustomsFee).ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: R$ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
