using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesLacoRepeticaoWhile
{
    internal class Exercicio4Tabuada
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para ver sua tabuada:");

            int numero = Convert.ToInt32(Console.ReadLine());
            int contador = 1; 

            while (contador <= 10)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                contador++; 
            }
        }
    }
}