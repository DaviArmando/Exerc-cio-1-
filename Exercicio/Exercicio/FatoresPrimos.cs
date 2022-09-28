using System;
using System.Collections.Generic;

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
            var fatores = new List<int>();

            while (numero > 1)
            {
                var e_divisivel = (numero % fator == 0);
                if (e_divisivel)
                {
                    fatores.Add(fator);
                    numero = numero / fator;
                }
                else
                    fator++;
            }

            Console.Write($"{numero_informado} = {string.Join(" x ", fatores)}");
        }
    }
}