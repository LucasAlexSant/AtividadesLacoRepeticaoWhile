using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesLacoRepeticaoWhile
{
    internal class Exercicio9ContagemDeVogais
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase ou palavra (digite 'fim' para encerrar).");

            while (true)
            {
                Console.Write("Entrada: ");
                string entrada = Console.ReadLine()?.ToLower();

                if (entrada == "fim")
                {
                    Console.WriteLine("Programa encerrado.");
                    break;
                }

                int contadorVogais = 0;
                foreach (char caractere in entrada)
                {
                    if ("aeiou".Contains(caractere))
                    {
                        contadorVogais++;
                    }
                }

                Console.WriteLine($"A frase contém {contadorVogais} vogais.");
            }
        }
    }
}