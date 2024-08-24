using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesagem_peixaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //máquina de peso, passando de 50Kg ele cobra R$4 por Kg
            double n1, n2;
            Console.Write("Digite o Quilo obtido: ");
            n1 = double.Parse(Console.ReadLine());
            if (n1 > 50)
            {
                n2 = n1 - 50;
                n2 = n2 * 4;
                Console.WriteLine($"Teve acrescimo de R${n2}");
            }
            else
            {
                Console.WriteLine("não teve acrescimo de valor.");
            }
            Console.ReadKey();
        }
    }
}
