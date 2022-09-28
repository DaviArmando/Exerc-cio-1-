using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Farenheit
    {
        public static void Run()
        {
            Console.WriteLine("Digite uma temperatura em Celsius para convertê-la");
            var C = Convert.ToInt32(Console.ReadLine());
            var F = Convert.ToInt32(C);
            F = (9 * C + 160) / 5;
            Console.WriteLine("A temperarura em Fahrenheit é {0}", F);
            Console.ReadLine();
        }
    }
}
