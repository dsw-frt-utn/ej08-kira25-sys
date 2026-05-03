using System;

namespace Problema1
{

	public partial class ProductHelper
	{
        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            
            return $"[{code}] {description} - {price:C}";
        }
    }
}