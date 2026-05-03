using System;

namespace Problema5
{
	public class Sale
	{
		public decimal Valor { get; set; }

		public virtual decimal CalculateTotal()
		{
			return Valor;
		}
	}
	public class RetailSale : Sale
	{
		public override decimal CalculateTotal() 
		{
			return Valor;
		}
	}
	public class WholesaleSale : Sale
	{
		public override decimal CalculateTotal()
		{
			return Valor * 0.9m;
		}
	}



	public class Problema5
	{
		public decimal ObtenerImporteFinal(Sale sale)
		{
			return sale.CalculateTotal();

		}

    }
}
