using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Tabuada
    {
        public static void Run()
        {
            Console.WriteLine("Bem vindo ao programa de tabuada");
            Console.WriteLine("Digite um número");
            var numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"##### TABUADA DE {numero} #####");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}
