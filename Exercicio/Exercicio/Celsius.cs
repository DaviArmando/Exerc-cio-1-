using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Celsius
    {
        public static void Run()
        {
            Console.WriteLine("Digite uma temperatura em Fahrenheit para convertê-la");
            var F = Convert.ToInt32(Console.ReadLine());
            var C = Convert.ToInt32(F);
            C = (F - 32) * 5 / 9;
            Console.WriteLine("Atemperatura em Celsius é {0}", C);
            Console.ReadLine();
        }
    }
}
