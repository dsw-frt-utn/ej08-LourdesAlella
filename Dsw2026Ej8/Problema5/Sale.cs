using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema5
{
    internal class Sale
    {
        protected decimal sale_;

        public Sale(decimal sale)
        {
            sale_ = sale;
        }

        public virtual decimal CalculateTotal()
        {
            return sale_;
        }
    }
}
