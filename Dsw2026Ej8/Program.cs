using Dsw2026Ej8.Problema1;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProbarProblema1();
        }

        static void ProbarProblema1()
        {
            Console.WriteLine(" === PROBLEMA 1 === ");
            var helper = new ProductHelper();
            Console.WriteLine(helper.ObtenerEtiquetaProducto(1, "Producto A", 100.50m));
        }
    }
}
