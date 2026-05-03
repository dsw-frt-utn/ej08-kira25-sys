using System;

namespace Problema3
{
    public class Product
    {
        public string Description { get; set; }

		public void UpdateDescritcion(string description) 
		{
			Description = description;
		}
    }

    public class Comparar
	{
		
		public string CompararCopias(int originalValue, Product product)
		{
			int original = originalValue;

			
				original++;

			
			Product copyProducto = product;

			copyProducto.UpdateDescritcion("descripcion modificada");

			return $"{originalValue}-{original}-{product.Description}";
		}
	}
}