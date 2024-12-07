using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesLacoRepeticaoWhile
{
    internal class Exercicio2Soma
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int numero1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine( "a soma dos dois numero são igual a " +(numero1 + numero2).ToString());
        }
    }
}
