using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] notas = new double[4,4];
            int n1, n2;
            for (n1 = 0; n1 < 4; n1++) {
                for (n2 = 0; n2 < 4; n2++)
                {
                    Console.Write($"Nota {n2 + 1} do aluno {n1 + 1}: ");
                    notas[n1, n2] = double.Parse(Console.ReadLine());
                }
            }
            for (n1 = 0; n1 < 4; n1++)
            {
                Console.Write("\nA média do aluno "+(n1+1)+ " é: "+ ((notas[n1,0]+notas[n1,1] + notas[n1, 2] + notas[n1, 3])/4));
            }
               
            Console.ReadKey();
        }
    }
}
