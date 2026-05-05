using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Dsw2026Ej8.Problema6
{
    public static class Extensions
    {
        public static string ToProductCode(this string? code)
        {
          return code == null ? "SIN-CODIGO" : code.Trim().ToUpper().Replace(" ", "-");
        }
    }
}
