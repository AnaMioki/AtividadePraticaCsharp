using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePraticaCsharp
{
    internal class EscolhaDeBebida
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha sua bebida:");
            Console.WriteLine("1) Café");
            Console.WriteLine("2) Chá");
            Console.WriteLine("3) Suco");

            int bebida = Convert.ToInt16(Console.ReadLine());


            switch (bebida)
            {
                case 1:
                    Console.WriteLine("Café");
                    break;

                case 2:
                    Console.WriteLine("Chá");
                    break;

                case 3:
                    Console.WriteLine("Suco");
                    break;

                default:
                    Console.WriteLine("Erro. Opção inválida");
                    break;
            }
        }
    }
}
