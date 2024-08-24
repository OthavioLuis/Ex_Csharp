using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = new string[5];
            for (int x = 0; x < 5; x++)
            {
                Console.Write("Digite um número: ");
                numeros[x] = Console.ReadLine();
            }
            for (int x = 0; x < 5; x++)
            {
                Console.Write("\nOs números guardados foram: ");
                for (x = 0; x < 5; x++)
                {
                    Console.Write(numeros[x]+", ");
                }
            }
            Console.ReadKey();
        }
    }
}
