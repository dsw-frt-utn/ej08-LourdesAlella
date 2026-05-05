using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema1
{
    public partial class ProductHelper
    {
        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            string formatCode = FormatCode(code);
            return $" {formatCode} {description}{separator}{price:C}";
        }
    }
}
