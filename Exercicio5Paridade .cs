using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesLacoRepeticaoWhile
{
    internal class Exercicio5Paridade
    {
        public static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.WriteLine("Digite um número:");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 != 0) 
                {
                    Console.WriteLine("Número ímpar!.");
                }

            } while (numero % 2 != 0); 

            Console.WriteLine("Você digitou um número par.");
        }
    }
}