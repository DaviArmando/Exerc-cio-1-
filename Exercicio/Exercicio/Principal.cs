using System;

namespace Exercicio
{
    public static class Principal
    {
        public static void Main(string[] args)
        {
            var opcao = "0";
            while (opcao != "x")
            {
                Console.WriteLine("Qual programa deseja executar? ");
                Console.WriteLine("1 - AnoBissexto");
                Console.WriteLine("2 - FatoresPrimos");
                Console.WriteLine("3 - FizzBuzz");
                Console.WriteLine("4 - NumeroPrimo");
                Console.WriteLine("5 - Calculadora");
                Console.WriteLine("6 - Tabuada");
                Console.WriteLine("7 - Farenheit");
                Console.WriteLine("8 - Celsius");
                Console.WriteLine("9 - Positivo ou Negativo");
                Console.WriteLine("10 - Palindromos");
                Console.WriteLine("x - Sair");
                opcao = Console.ReadLine();
                if (opcao == "1")
                    AnoBissexto.Run();

                else if (opcao == "2")
                    FatoresPrimos.Run();

                else if (opcao == "3")
                    FizzBuzz.Run();

                else if (opcao == "4")
                    NumeroPrimo.Run();

                else if (opcao == "5")
                    Calculadora.Run();

                else if (opcao == "6")
                    Tabuada.Run();

                else if (opcao == "7")
                    Farenheit.Run();

                else if (opcao == "8")
                    Celsius.Run();

                else if (opcao == "9")
                    PositivoNegativo.Run();

                else if (opcao == "10")
                    PalavrasPalindromas.Run();
            }
        }
    }
}