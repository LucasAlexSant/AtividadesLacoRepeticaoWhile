using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesLacoRepeticaoWhile
{
    internal class Exercicio8BuscaDeNumero
    {
        public static void Main(string[] args)
        {
            int numeroSecreto = 42; 
            int tentativa;

            Console.WriteLine("Tente adivinhar o número secreto.");

            while (true) 
            {
                Console.Write("Digite seu palpite: ");
                tentativa = Convert.ToInt32(Console.ReadLine());

                if (tentativa == numeroSecreto)
                {
                    Console.WriteLine("Parabéns! Você acertou o número secreto!");
                    break; 
                }
                else if (tentativa < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior. Tente novamente.");
                }
                else
                {
                    Console.WriteLine("O número secreto é menor. Tente novamente.");
                }
            }
        }
    }
}