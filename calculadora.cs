using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caluculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------");
            Console.WriteLine(" Calculadora ");
            Console.WriteLine("-------------");
            Console.WriteLine("pessione enter para começar");
            Console.ReadLine();
            menu();
        }

        static void menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair\n");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    adicao();
                    break;
                case "2":
                    subtracao();
                    break;
                case "3":
                    divisao();
                    break;
                case "4":
                    multiplicacao();
                    break;
                case "5":
                    break;
                default:
                    menu();
                    break;
            }
        }

        static void adicao()
        {
            double n1, n2;
            Console.Write("Digite um valor: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write($"{n1} + {2} = {n1 + n2}");
            Console.ReadLine();
            menu();
        }

        static void subtracao()
        {
            double n1, n2;
            Console.Write("Digite um valor: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write($"{n1} - {2} = {n1 - n2}");
            Console.ReadLine();
            menu();
        }

        static void divisao()
        {
            double n1, n2;
            Console.Write("Digite um valor: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write($"{n1} * {2} = {n1 * n2}");
            Console.ReadLine();
            menu();
        }

        static void multiplicacao()
        {
            double n1, n2;
            Console.Write("Digite um valor: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write($"{n1} / {2} = {n1 / n2}");
            Console.ReadLine();
            menu();
        }
    }
}
