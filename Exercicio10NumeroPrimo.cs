using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesLacoRepeticaoWhile
{
    internal class Exercicio10NumeroPrimo
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número para verificar: ");

            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero <= 1)
            {
                Console.WriteLine("O número não é primo.");
            }
            else
            {
                int divisor = 2;
                bool ehPrimo = true;

                while (divisor <= Math.Sqrt(numero)) 
                {
                    if (numero % divisor == 0)
                    {
                        ehPrimo = false; 
                        break;
                    }
                    divisor++;
                }

                if (ehPrimo)
                {
                    Console.WriteLine($"O número {numero} é primo.");
                }
                else
                {
                    Console.WriteLine($"O número {numero} não é primo.");
                }
            }
        }
    }
}