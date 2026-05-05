using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema4
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double sum = 0;
            int validNotes = 0;
            int?[] notas = { nota1, nota2, nota3 };

            foreach (int? nota in notas)
            {
                if(nota.HasValue && nota.Value >=0 && nota.Value <=10)
                {
                    sum += nota.Value;
                    validNotes++;
                }
            }

            return validNotes == 0 ? 0 : sum/validNotes;
        }
    }
}
