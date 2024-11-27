using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePraticaCsharp
{
    internal class CalculadoraDeImpostos
    {
        public static void Main(string[] args) { 
        // Até R$1.500,00: Imposto de 5% 

        //De R$1.501,00 a R$3.000,00: Imposto de 10% 

        //Acima de R$3.000,00: Imposto de 15% 
        //Acima de R$3.000,00: Imposto de 15% 

        //Peça o valor do salário e calcule o imposto.

        Console.WriteLine("Digite a quantia de seu salário: ");
        double salario = Convert.ToDouble(Console.ReadLine());
        double imposto = 0;

        int faixaDeSalario;
            if (salario <= 1500)
                faixaDeSalario = 1;  
            else if (salario <= 3000)
                faixaDeSalario = 2;  
            else
                faixaDeSalario = 3; 

            switch (faixaDeSalario)
            {
                case 1:
                    imposto = salario * 0.05; 
                    break;

                case 2:
                    imposto = salario * 0.10; 
                    break;

                case 3:
                    imposto = salario * 0.15; 
                    break;
            }

            Console.WriteLine("O valor do imposto é: R$ " + imposto.ToString("F2"));
        }
    }
}
