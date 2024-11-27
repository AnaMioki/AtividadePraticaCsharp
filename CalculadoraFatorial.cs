using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePraticaCsharp
{
    internal class CalculadoraFatorial
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para calcular o fatorial:");
            int numero = Convert.ToInt16(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Não dá para calcular o fatorial de um número negativo.");
                return;
            }

            int fatorial = 1;
            switch (numero)
            {
                case int n when n == 0:
                    fatorial = 1;  
                    break;

                case int n when n > 0:
                    for (int i = 1; i <= numero; i++)
                    {
                        fatorial *= i;
                    }
                    break;

                default:
                    Console.WriteLine("Erro: número inválido.");
                    return;
            }

            Console.WriteLine("O fatorial de " + numero + " é " + fatorial);
        }
    }
}
