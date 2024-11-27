using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePraticaCsharp
{
    internal class ConversorDeTemperatura
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1) Celsius para Fahrenheit");
            Console.WriteLine("2) Fahrenheit para Celsius");


            int opcao = Convert.ToInt16(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a temperatura em Celsius: ");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine(celsius + "°C é igual a " + fahrenheit.ToString("F2") + "°F.");
                    break;

                case 2:
                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine(fahrenheit + "°F é igual a " + celsius.ToString("F2") + "°C");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
