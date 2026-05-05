using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Dsw2026Ej8.Problema2
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            var resumen = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = quantity <= 0 ? 0 : (quantity * unitPrice)
            };

            return $" {resumen.Code}-{resumen.Description}-{resumen.Total}";
        }
    }
}
