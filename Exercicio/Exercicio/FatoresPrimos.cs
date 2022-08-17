using System;

namespace Exercicio
{
    public class FatoresPrimos
    {
        public static void Run()
        {
			Console.WriteLine("Bem Vindo ao programa de Fatores Primos");
            Console.Write("Digite um número: ");
            var numero_informado = Console.ReadLine();
            var numero = Convert.ToInt32(numero_informado);
            var fator = 2;
            Console.Write($"{numero} = ");
            while (numero > 1)
            {
                var e_divisivel = (numero % fator == 0);
                if (e_divisivel)
                {
                    Console.Write($"{fator} x ");
                    numero = numero / fator;
                }
                else
                    fator++;
            }
            Console.WriteLine($"1");
        }
    }
}