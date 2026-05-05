using Dsw2026Ej8.Problema1;
using Dsw2026Ej8.Problema2;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProbarProblema1();
            ProbarProblema2();
        }

        static void ProbarProblema1()
        {
            Console.WriteLine(" === PROBLEMA 1 === ");
            var helper = new ProductHelper();
            Console.WriteLine(helper.ObtenerEtiquetaProducto(100, "Producto A", 99.50m));
        }

        static void ProbarProblema2()
        {
            Console.WriteLine("\n === PROBLEMA 2 === ");
            var prueba2 = new Problema2.Problema2();
            Console.WriteLine(prueba2.CrearResumenVenta(200, "Producto B", 2, 200));
        }
    }
}
