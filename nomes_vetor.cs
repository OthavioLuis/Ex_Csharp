using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[4];
            for (int x = 0; x < 4; x++)
            {
                Console.Write("Digite um nome: ");
                nomes[x] = Console.ReadLine();
            }
            Console.WriteLine("Nomes guardados no banco de dados.");
            Console.WriteLine("Pressione 'Enter' para finalizar.");
            Console.ReadKey();
        }
    }
}
