using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesLacoRepeticaoWhile
{
    internal class Exercicio13ContarParesImpares
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao programa de contagem de pares e ímpares!");
            Console.WriteLine("Digite números inteiros. Digite 0 para encerrar.");

            int numero = -1; 
            int contagemPares = 0;
            int contagemImpares = 0;

            while (numero != 0)
            {
                Console.Write("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero != 0) 
                {
                    if (numero % 2 == 0)
                    {
                        contagemPares++;
                    }
                    else
                    {
                        contagemImpares++;
                    }
                }
            }

            Console.WriteLine($"Você digitou {contagemPares} número(s) par(es) e {contagemImpares} número(s) ímpar(es).");
        }
    }
}