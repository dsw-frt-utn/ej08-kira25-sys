 
using System;

using Problema1;
using Problema2;
using Problema3;
using Problema4;
using Problema5;
using Problema6;




namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductHelper helper = new ProductHelper();
            string etiqueta = helper.ObtenerEtiquetaProducto(5550, "hola funciono", 344);
            Console.WriteLine("--- Problema 1 ---");
            Console.WriteLine(etiqueta);
            Console.WriteLine("----------");

            CrearResumen problema2 = new CrearResumen();
            string prob = problema2.CreaResumenVenta(123, "hola", 2, 4);
            Console.WriteLine("--- Problema 2 ---");
            Console.WriteLine(prob);
            Console.WriteLine("----------");

            Comparar problemas3 = new Comparar();
            Product miProducto = new Product();
            miProducto.Description = "Producto Original";
            string comp = problemas3.CompararCopias(3, miProducto);
            Console.WriteLine("--- Problema 3 ---");
            Console.WriteLine(comp);
            Console.WriteLine("----------");

            Problema4.Problema4 problema4 = new Problema4.Problema4();
            double promedio = problema4.CalcularPromedio(1,1,1);
            Console.WriteLine("--- Problema 4 ---");
            Console.WriteLine(promedio);
            Console.WriteLine("----------");

            Sale valor = new Sale { Valor = 100  };
            Problema5.Problema5 problema5 = new Problema5.Problema5();
            decimal importe = problema5.ObtenerImporteFinal(valor);
            Console.WriteLine("--- Problema 5 ---");
            Console.WriteLine(importe);
            RetailSale retail = new RetailSale { Valor = 100 };
            WholesaleSale wholesale = new WholesaleSale { Valor = 100 };

            Console.WriteLine($"Con RetailSale : {problema5.ObtenerImporteFinal(retail)}");
            Console.WriteLine($"Con WholesaleSale : {problema5.ObtenerImporteFinal(wholesale)}");
            Console.WriteLine("----------");



            Console.WriteLine("--- Problema 6  ---");
            Problema6.Problema6 corrector = new Problema6.Problema6();
            string palabra = corrector.NormalizarCodigoProducto(null);
            Console.WriteLine(palabra);
            Console.WriteLine("----------");


        }
    }
}
