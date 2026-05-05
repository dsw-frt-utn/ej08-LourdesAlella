using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema5
{
    internal class WholesaleSale : Sale
    {
        public WholesaleSale(decimal sale) : base(sale) { }

        public override decimal CalculateTotal()
        {
            return sale_ * 0.9m;
        }
    }
}
