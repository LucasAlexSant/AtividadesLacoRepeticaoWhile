using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesLacoRepeticaoWhile
{
    internal class Exercicio11ContagemDeDigitos
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");

            int numero =Convert.ToInt32(Console.ReadLine());
            int contador = 0;

            if (numero == 0)
            {
                contador = 1;
            }
            else
            {
                while (numero > 0)
                {
                    numero /= 10;
                    contador++;
                }
            }

            Console.WriteLine($"O número digitado possui {contador} dígito(s).");
        }
    }
}