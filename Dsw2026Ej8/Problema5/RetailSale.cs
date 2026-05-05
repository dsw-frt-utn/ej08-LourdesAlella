using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema5
{
    internal class RetailSale : Sale
    {
        public RetailSale(decimal sale) : base(sale) { }

        public override decimal CalculateTotal()
        {
            return base.CalculateTotal();
        }
    }
}
