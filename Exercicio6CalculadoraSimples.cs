using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesLacoRepeticaoWhile
{

        internal class Exercicio6CalculadoraSimples
        {
            public static void Main(string[] args)
            {
                string operacao;

                Console.WriteLine("Bem-vindo à Calculadora");
                Console.WriteLine("Digite uma operação (+, -, *, /) ou 'sair' para encerrar.");

                do
                {
                    Console.Write("Escolha uma operação: ");
                    operacao = Console.ReadLine().ToLower(); 

                    if (operacao == "sair")
                    {
                        Console.WriteLine("Encerrando a calculadora.");
                        break; 
                    }

                    
                    Console.Write("Digite o primeiro número: ");
                    double numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    double numero2 = Convert.ToDouble(Console.ReadLine());

                    
                    switch (operacao)
                    {
                        case "+":
                            Console.WriteLine($"Resultado: {numero1} + {numero2} = {numero1 + numero2}");
                            break;
                        case "-":
                            Console.WriteLine($"Resultado: {numero1} - {numero2} = {numero1 - numero2}");
                            break;
                        case "*":
                            Console.WriteLine($"Resultado: {numero1} * {numero2} = {numero1 * numero2}");
                            break;
                        case "/":
                            if (numero2 != 0)
                            {
                                Console.WriteLine($"Resultado: {numero1} / {numero2} = {numero1 / numero2}");
                            }
                            else
                            {
                                Console.WriteLine("Divisão por zero não é permitida");
                            }
                            break;
                        default:
                            Console.WriteLine("Operação inválida! Tente novamente.");
                            break;
                    }

                } while (true); 
            }
        }
    }
