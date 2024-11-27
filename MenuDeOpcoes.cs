using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePraticaCsharp
{
    internal class MenuDeOpcoes
    {
        public static void Main(string[] args)
        {
            // Exibe as opções para o usuário
            Console.WriteLine("Digite uma opção");
            Console.WriteLine("1) Olá mundo!");
            Console.WriteLine("2) Bem-vindo ao C#");
            Console.WriteLine("3) Sair");
            Console.WriteLine(" ");

            // Captura a opção escolhida
            int opcao = Convert.ToInt16(Console.ReadLine());

            // Processa a opção escolhida
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Olá mundo!");
                    break;

                case 2:
                    Console.WriteLine("Bem-vindo ao C#!");
                    break;

                case 3:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
