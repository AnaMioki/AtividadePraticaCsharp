using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePraticaCsharp
{
    internal class ClassificacaoDeIdade
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());


            switch (idade)
            {
                case int n when (n >= 0 && n <= 12):
                    Console.WriteLine("Você é criança");
                    break;

                case int n when (n >= 13 && n <= 17):
                    Console.WriteLine("Você é adolecente");
                    break;

                case int n when (n >= 18 && n <= 59):
                    Console.WriteLine("Você é adulto");
                    break;

                case int n when (n >= 60 && n <= 99):
                    Console.WriteLine("Você é idoso");
                    break;

                case int n when (n >= 100):
                    Console.WriteLine("Aqui ja virou imortal, parabens!!");
                    break;

                default:
                    Console.WriteLine("Idade inválida");
                    break;
            }
        }
    }
}
