using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_nmr
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            
            Console.Write("Digite o 1° número: ");

            b = int.Parse(Console.ReadLine());
            for (c = 1; c < 15; c++)

            {
                Console.Write("Digite o {0}° número: ", c + 1);
                a = int.Parse(Console.ReadLine());

                if (a > b)
                {
                    b = a;
                }
            }
            Console.WriteLine("\nO maior número digitado foi: {0}", b);

            Console.ReadKey();
        }
    }
}
