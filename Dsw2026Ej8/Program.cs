using Dsw2026Ej8.Problema1;
using Dsw2026Ej8.Problema2;
using Dsw2026Ej8.Problema3;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProbarProblema1();
            ProbarProblema2();
            ProbarProblema3();
            
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

        static void ProbarProblema3()
        {
            Console.WriteLine("\n === PROBLEMA 3 === ");
            var prueba3 = new Problema3.Problema3();
            Product productoPrueba = new Product("Producto C");
            Console.WriteLine(prueba3.CompararCopias(30, productoPrueba));
        }
    }
}
