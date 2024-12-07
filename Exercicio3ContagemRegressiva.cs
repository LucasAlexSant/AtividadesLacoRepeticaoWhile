using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesLacoRepeticaoWhile
{
    internal class Exercicio3ContagemRegressiva
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");

                int numero = Convert.ToInt16(Console.ReadLine());

            while (numero > -1)
            {
                Console.WriteLine(numero);
                numero--;
            }
        }
    }
}
