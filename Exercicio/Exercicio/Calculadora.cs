using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Calculadora
    {
        public static void Run()
        {
            Console.WriteLine("Digite dois números");
            var numero1 = Convert.ToInt32(Console.ReadLine());
            var numero2 = Convert.ToInt32(Console.ReadLine());
            var opcao = "0";
            Console.WriteLine("Agora escolha uma opção :");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
            Console.WriteLine("x- Sair");
            opcao = Console.ReadLine();
            if (opcao == "1")
            {
                Console.WriteLine(numero1 + numero2);
            }
            else if (opcao == "2")
            {
                Console.WriteLine(numero1 - numero2);
            }
            else if (opcao == "3")
            {
                Console.WriteLine(numero1 * numero2);
            }
            else if (opcao == "4")
            {
                Console.WriteLine(numero1 / numero2);
            }

        }
    }
}
