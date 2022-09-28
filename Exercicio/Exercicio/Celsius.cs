using System;

namespace Exercicio
{
    public class Celsius
    {
        /// <summary>
        /// PascalCase
        /// camelCase
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Digite uma temperatura em Fahrenheit para convertê-la");
            var temperaturaEmFahrenheit = Convert.ToInt32(Console.ReadLine());
            var temperaturaEmCelsius = (temperaturaEmFahrenheit - 32) * 5 / 9;
            Console.WriteLine("Atemperatura em Celsius é {0}", temperaturaEmCelsius);
        }
    }
}
