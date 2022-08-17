using System;

namespace Exercicio
{
	public class AnoBissexto
	{
		public static void Run()
		{
			Console.WriteLine("Bem Vindo ao programa de Ano Bissexto");
			Console.Write("Digite o ano: ");
			var anoInformado = Console.ReadLine();
			var ano = Convert.ToInt32(anoInformado);

			//"O ano for divisível por 4, mas não divisível por 100, exceto se ele for também divisível por 400."

			var anoDividePor4 = ano % 4 == 0;
			var anoDividePor100 = ano % 100 == 0;
			var anoDividePor400 = ano % 400 == 0;

			if (anoDividePor400)
			{
				Console.WriteLine("Esse ano é bissexto");
			}
			else if (anoDividePor4 && !anoDividePor100)
			{
				Console.WriteLine("Esse ano é bissexto");
			}
			else
			{
				Console.WriteLine("Esse ano não é bissexto");
			}
		}
	}
}