using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class PalavrasPalindromas
    {
        public static void Run()

        {
            
            Console.WriteLine("Digite uma palavra ou uma frase");
            var palavra = Console.ReadLine();
            var x = palavra.Length - 1;

            while (x != -1)
            {
                for (int y = 0; y < palavra.Length; y++)

                    if (palavra[y] == palavra[x])
                    {
                        if (x == 0)
                        {
                            Console.WriteLine("É Palíndromo");
                            
                        }
                        x--;
                    }
                    else
                    {
                        Console.WriteLine("Não é Palíndromo");
                        y = palavra.Length;
                        x = -1;
                        
                    }
            }

        }

    }
}
