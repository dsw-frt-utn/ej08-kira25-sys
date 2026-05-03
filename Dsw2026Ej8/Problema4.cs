using System;

namespace Problema4
{
	public class Problema4
	{
		public double CalcularPromedio (int? nota1, int? nota2 , int? nota3)
		{
			
				double promedio = 0;
				int cuenta = 0;
				double acumulador = 0;

				if (nota1 >= 0 && nota1 <= 10)
				{
					acumulador = acumulador + nota1.Value;
					cuenta++;
				}

				if (nota2 >= 0 && nota2 <= 10)
				{
					acumulador = acumulador + nota2.Value;
					cuenta++;
				}

				if (nota3 >= 0 && nota3 <= 10)
				{
					acumulador = acumulador + nota3.Value;
					cuenta++;
				}

				if (cuenta == 0) 
				{
					return 0; 
				}

				promedio = acumulador / cuenta;

				return promedio;
			
			
		}
	}
}
