using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema3
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int valorCopia = originalValue;
            valorCopia++;
            Product productoCopia = product;
            productoCopia.SetDescription("Modificada");

            return $"{originalValue}-{valorCopia}-{product.GetDescription()}";
        }
    }
}
