using System;

namespace Exercicio
{
    public class FizzBuzz
    {
        public static void Run()
        {
			Console.WriteLine("Bem Vindo ao programa de FizzBuzz");
			Console.Write("Escreva um número : ");
            var numero = Convert.ToInt32(Console.ReadLine());

            for (var i = 1; i <= numero; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}