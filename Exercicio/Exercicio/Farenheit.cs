using System;

namespace Exercicio
{
    public class Farenheit
    {
        public static void Run()
        {
            Console.WriteLine("Digite uma temperatura em Celsius para convertê-la");
            var temperaturaCelsius = Convert.ToInt32(Console.ReadLine());
            var temperaturaFahrenheit = (9 * temperaturaCelsius + 160) / 5;
            Console.WriteLine("A temperarura em Fahrenheit é {0}", temperaturaFahrenheit);
        }
    }
}
