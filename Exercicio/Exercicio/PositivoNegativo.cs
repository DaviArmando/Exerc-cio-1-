using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class PositivoNegativo
    {
        public static void Run()
        {
            Console.WriteLine("Verificador de número");
            Console.WriteLine("Write a number");
            var numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine("Positivo");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
            Console.ReadLine();
        }
    }
}
