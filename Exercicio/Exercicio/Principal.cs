using System;

namespace Exercicio
{
	public static class Principal
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Qual programa deseja executar? ");
			Console.WriteLine("1 - AnoBissexto");
			Console.WriteLine("2 - FatoresPrimos");
			Console.WriteLine("3 - FizzBuzz");
			Console.WriteLine("4 - NumeroPrimo");
			var opcao = Console.ReadLine();

			
			AnoBissexto.Run();
			FatoresPrimos.Run();
			FizzBuzz.Run();
			NumeroPrimo.Run();
		}
	}
}