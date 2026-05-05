using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace Dsw2026Ej8.Problema1
{
    public partial class ProductHelper
    {
        private const string separator = " - ";

        private string FormatCode(long code)
        {
            return $"[{code}]";
        }
    }
}
