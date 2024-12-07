using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesLacoRepeticaoWhile
{
    internal class Exercicio14SomaDosPares
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao programa de soma dos números pares!");
            Console.WriteLine("Digite números inteiros. Digite 0 para encerrar.");

            int numero = -1; 
            int soma = 0;

            while (numero != 0)
            {
                Console.Write("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0 && numero != 0) 
                {
                    soma += numero;
                }
            }

            Console.WriteLine($"A soma dos números pares digitados é: {soma}");
        }
    }
}