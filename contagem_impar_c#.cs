using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contagem_nmr_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, v4, v5, x;
            int v3 = 0;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Contagem dos números Ímpares");
            Console.WriteLine("-----------------------------");
            Console.Write("Digite o primeiro número: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            v2 = int.Parse(Console.ReadLine());
            if (v1 <= v2)
            {
                v4 = v1;
                v5 = v2;
            }
            else
            {
                v4 = v2;
                v5 = v1;
            }
            for (x = v4; x <= v5; x++)
            {
                if (x % 2 == 1) { v3++; }
            }
            Console.WriteLine("Entre " + v1 + " e " + v2 + " há : " + v3 + " números ímpares");



            Console.ReadKey();
        }
    }
}
