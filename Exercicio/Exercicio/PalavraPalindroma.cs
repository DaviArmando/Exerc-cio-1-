using System;
using System.Text.RegularExpressions;

namespace Exercicio
{
	public class PalavraPalindroma
	{
		public static void Run()
		{
			Console.WriteLine("Digite uma palavra ou uma frase");
			var textoDigitado = Console.ReadLine();
			var textoMaiusculo = textoDigitado.ToUpper();
			var textoLimpo = Regex.Replace(textoMaiusculo, "[^0-9A-Z]", "");

			var ehPalindromo = true;
			var meioTexto = textoLimpo.Length / 2;

			for (var x1 = 0; (x1 < meioTexto) && ehPalindromo; x1++)
			{
				var x2 = textoLimpo.Length - x1 - 1;

				if (textoLimpo[x1] != textoLimpo[x2])
					ehPalindromo = false;
			}

			if (ehPalindromo)
				Console.WriteLine("É Palíndromo");
			else
				Console.WriteLine("Não é Palíndromo");
		}
	}
}