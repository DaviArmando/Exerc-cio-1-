using System;

namespace Exercicio
{
	public class NumeroPrimo
	{
		public static void Run()
		{
			Console.WriteLine("Bem Vindo ao programa de De Números Primos");
			Console.Write("Escreva um número : ");
			var numero = Convert.ToInt32(Console.ReadLine());
			var raizQuadrada = Convert.ToInt32(Math.Sqrt(numero));
			var ehPrimo = true;

			for (var i = 2; (i < raizQuadrada) && ehPrimo; i++)
			{
				if (numero % i == 0)
					ehPrimo = false;
			}

			if (ehPrimo)
			{
				Console.WriteLine("Esse número é primo");
			}
			else
			{
				Console.WriteLine("Esse número não é primo");
			}
		}
	}
}