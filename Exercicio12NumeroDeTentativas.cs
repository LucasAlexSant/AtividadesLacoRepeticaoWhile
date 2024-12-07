using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesLacoRepeticaoWhile
{
    internal class Exercicio12NumeroDeTentativas
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao programa de validação de número!");
            int numero = 0;

            while (numero < 1 || numero > 100) 
            {
                Console.Write("Digite um número entre 1 e 100: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 1 || numero > 100)
                {
                    Console.WriteLine("Número inválido.");
                }
            }

            Console.WriteLine($"Número válido digitado: {numero}");
        }
    }
}
