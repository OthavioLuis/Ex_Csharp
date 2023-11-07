using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notas_semestre
{
    class Program
    {
        static void Main(string[] args)
        {
            //teste de Array bidimensional
            //alunos/linhas = 4
            //notas/colunas = 4
            double[,] notas = new double[4, 4];
            int n1, n2;
            Console.WriteLine("Olá professor(a), vamos calcular a média de seus alunos?!");
            Console.WriteLine("pressione 'Enter' para começar.");
            Console.ReadLine();
            for (n1 = 0; n1 < 4; n1++)
            {
                for (n2 = 0; n2 < 4; n2++)
                {
                    Console.Write($"Nota {n2 + 1} do aluno {n1 + 1}: ");
                    notas[n1, n2] = double.Parse(Console.ReadLine());
                }
            }
            for (n1 = 0; n1 < 4; n1++)
            {
                Console.Write("\nA média do aluno " + (n1 + 1) + " é: " + ((notas[n1, 0] + notas[n1, 1] + notas[n1, 2] + notas[n1, 3]) / 4));
            }
            Console.ReadKey();
        }
    }
}
