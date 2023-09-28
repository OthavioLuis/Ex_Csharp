using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taboada
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("digite valor da taboada:");
            b = int.Parse(Console.ReadLine());

            for (a = 1; a <= 10; a++)
            {
                c = b * a;
                Console.WriteLine(+b + " X " + a + " = " + c);
            }

            Console.ReadKey();
        }
    }
}
