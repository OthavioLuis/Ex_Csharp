using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[6];
            double[] idade = new double[6];
            string[] local = new string[6];
            int x;
            Console.WriteLine("Vamos cadastrar um banco de dados ");
            for (x = 0; x < 6; x++)
            {
                Console.Write("\nDigite um nome: ");
                nome[x] = Console.ReadLine();
                Console.Write("Digite a idade; ");
                idade[x] = double.Parse(Console.ReadLine());
                Console.Write("Digite agora a cidade: ");
                local[x] = Console.ReadLine();
            }
            Console.WriteLine("\nParabéns, seus dados foram salvos.");
            Console.WriteLine("Clique ENTER para finalizar.");

            Console.ReadKey();
        }
    }
}
