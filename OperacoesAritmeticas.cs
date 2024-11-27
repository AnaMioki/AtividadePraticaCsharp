using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePraticaCsharp
{
    internal class OperacoesAritmeticas
    {
        public static void Main(string[] args)
        {
            sbyte[] numeros = new sbyte[2];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}: ");

                while (!sbyte.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.WriteLine("Entrada inválida! Insira um número entre -128 e 127:");
                }
            }

            Console.WriteLine("Digite um operador aritmético (+, -, *, /) para realizar o cálculo.");
            char operador;
            while (!char.TryParse(Console.ReadLine(), out operador) || "+-*/".IndexOf(operador) == -1)
            {
                Console.WriteLine("Operador inválido! Escolha entre +, -, *, /");
            }

            try
            {
                sbyte resultado = 0;

                switch (operador)
                {
                    case '+':
                        resultado = checked((sbyte)(numeros[0] + numeros[1]));
                        break;
                    case '-':
                        resultado = checked((sbyte)(numeros[0] - numeros[1]));
                        break;
                    case '*':
                        resultado = checked((sbyte)(numeros[0] * numeros[1]));
                        break;
                    case '/':
                        if (numeros[1] != 0)
                        {
                            resultado = checked((sbyte)(numeros[0] / numeros[1]));
                        }
                        else
                        {
                            Console.WriteLine("Divisão: Não é possível dividir por zero.");
                            return;
                        }
                        break;
                    
                }
                Console.WriteLine($"Resultado da operação {numeros[0]} {operador} {numeros[1]} = {resultado}");

            }
            catch (OverflowException)
            {
                Console.WriteLine("Erro: A operação causou um overflow.");
            }
        }
    }
}
