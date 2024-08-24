using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Gravar mensagem em arquivo binário");
                Console.WriteLine("2 - Ler Arquivo de Texto");
                Console.WriteLine("0 - Sair ");
                Console.Write("\nDigite a opção desejada: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Cadastrar();
                        break;

                    case 2:
                        Ler();
                        break;

                    case 0:
                        break;
                    default: Console.WriteLine("Opção inválida.");
                        break;

                } Console.WriteLine("\n\nPressione alguma tecla para cntinuar!!");
                Console.ReadKey();
            }
            while (op != 0);
        }
        static void Cadastrar()
        {
            string conteudo;
            FileStream streamCadastrar;

            Console.Write("Digite algo e será gravado no Arquivo Binário: ");
            conteudo = Console.ReadLine();
            if (!File.Exists(@"C:\teste1\cadastrar.bin"))
            {
                streamCadastrar = new FileStream(@"C:\teste1\cadastrar.bin", FileMode.Create);
            }
            else
            {
                streamCadastrar = new FileStream(@"C:\teste1\cadastrar.bin", FileMode.Open);
            }
            using (BinaryWriter writer = new BinaryWriter(streamCadastrar))
            {
                writer.Write(conteudo);
                writer.Flush();
                writer.Close();
            }
            Console.WriteLine("Conteúdo gravado com sucesso no arquivo binário.");
        }

        static void Ler()
        {
            string caminho = @"C:\teste\ler.txt";
            System.IO.StreamReader sr;
            string linhaAtual;
            if (!System.IO.File.Exists(caminho))
            {
                throw (new System.IO.FileNotFoundException("Não foi possível localizar o Arquivo Especificado"));
            }
            using (sr = new System.IO.StreamReader(caminho))
            {
                while (!sr.EndOfStream)
                {
                    linhaAtual = sr.ReadLine();
                    Console.WriteLine(linhaAtual);
                }
            }
            Console.ReadKey();
        }
    }
}
