using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impar_ou_par
{
    class Program
    {
        static void Main(string[] args)
        {
        while (true) { 
            int num;

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Digite um número para descobrir se é IMPAR ou PAR: ");
            Console.WriteLine("-----------------------------------------------");
            num = int.Parse(Console.ReadLine());

            if (RestoPorDois(num) == 0)
                Console.WriteLine("\n\nO número é par. \n");
            else
                Console.WriteLine("\n\nO número é impar. \n");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static int RestoPorDois(int a)
        {
            return a % 2;
        }
    }
}
