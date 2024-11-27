using System;

namespace AtividadePraticaCsharp
{
    internal class NotaDoAluno
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite sua nota (De 0 a 10): ");
            int nota = Convert.ToInt16(Console.ReadLine());

            switch (nota)
            {
                // Faixa de notas de 0 a 2
                case int n when (n >= 0 && n <= 2):
                    Console.WriteLine("Sua classificação é F, estude mais.");
                    break;

                // Faixa de notas 3 e 4
                case int n when (n == 3 || n == 4):
                    Console.WriteLine("Sua classificação é D, pode melhorar.");
                    break;

                // Faixa de notas 5 e 6
                case int n when (n == 5 || n == 6):
                    Console.WriteLine("Sua classificação é C, quase lá.");
                    break;

                // Faixa de notas 7 e 8
                case int n when (n == 7 || n == 8):
                    Console.WriteLine("Sua classificação é B, bom.");
                    break;

                // Faixa de notas 9 e 10
                case int n when (n == 9 || n == 10):
                    Console.WriteLine("Sua classificação é A, perfect.");
                    break;

                // Caso de erro (nota inválida)
                default:
                    Console.WriteLine("Erro: nota inválida");
                    break;
            }
        }
    }
}
