using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[qt];
            for (int x = 0; x < qt; x++)
            {
                Console.Write("Quantos nomes queres adicionar a este banco? ");
                int qt = int.Parse(Console.ReadLine());
                Console.Write("Digite um nome: ");
                nomes[x] = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
