using System;

namespace Problema2
{

    public class CrearResumen
    {
        public string CreaResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal total;

            if (quantity <= 0)
            {
                total = 0;

            }
            else
            {

                total = quantity * unitPrice;

            }

            var anonima = new { Code = productCode, Description = productDescription, Quantity = quantity, Total = total };
         
            
             
            return $" { anonima.Code}--{ anonima.Description}--{ anonima.Total} ";
                        
        
        }
    }
}

