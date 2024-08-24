using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negativo_positivo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("-----------------------");
            Console.WriteLine("Olá, seja bem vindo!");
            Console.WriteLine("-----------------------");
            Console.Write("Vamos saber se é positivo ou negativo, digite um valor: ");
            a = double.Parse(Console.ReadLine());
            if (a >= 0)
            {
                Console.Write("é positivo");
            }
            else
            {
                Console.Write("É negativo");
            }
            Console.ReadKey();
        }
    }
}
