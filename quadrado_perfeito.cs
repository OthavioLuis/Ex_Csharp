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
            int x, add, valor, adic,tm;
            Console.Write("Quer adicionar quantos números? ");
            add = int.Parse(Console.ReadLine());
            for (x = 0; x < add; x++)
            {
                Console.Write("\nDigite o {0}º valor: ", x+1);
                valor = int.Parse(Console.ReadLine());
                for (tm = 1, adic = 0; adic < valor; tm++)
                {
                    adic = (tm * (2 + (tm - 1) * 2)) / 2;
                }
                if (valor >= 0)
                {
                    if (adic == valor)
                    {
                        Console.Write("True");
                    }
                    else
                    {
                        Console.Write("False");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
