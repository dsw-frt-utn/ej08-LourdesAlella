using Dsw2026Ej8.Problema1;
using Dsw2026Ej8.Problema2;
using Dsw2026Ej8.Problema3;
using Dsw2026Ej8.Problema5;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProbarProblema1();
            ProbarProblema2();
            ProbarProblema3();
            ProbarProblema4();
            ProbarProblema5();
            ProbarProblema6();
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

        static void ProbarProblema4()
        {
            Console.WriteLine("\n === PROBLEMA 4 === ");
            var prueba4 = new Problema4.Problema4();
            Console.WriteLine($"El promedio es: {prueba4.CalcularPromedio(9, null, 8)}");
        }

        static void ProbarProblema5()
        {
            Console.WriteLine("\n === PROBLEMA 5 === ");
            var prueba5 = new Problema5.Problema5();
            Sale salePrueba1 = new RetailSale(50.5m);
            Sale salePrueba2 = new WholesaleSale(1000m);

            Console.WriteLine($"Demostracion Ratail: {prueba5.ObtenerImporteFinal(salePrueba1)}");
            Console.WriteLine($"Demostracion Wholesale: {prueba5.ObtenerImporteFinal(salePrueba2)}");
        }

        static void ProbarProblema6()
        {
            Console.WriteLine("\n === PROBLEMA 6 === ");
            var prueba6 = new Problema6.Problema6();
            string codePrueba1 = " abc 123 x ";
            string? codeNulo = null;

            Console.WriteLine(prueba6.NormalizarCodigoProducto(codePrueba1));
            Console.WriteLine(prueba6.NormalizarCodigoProducto(codeNulo));
        }
    }
}
