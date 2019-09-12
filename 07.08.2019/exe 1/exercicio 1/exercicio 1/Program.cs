using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string cidade, nome;

            Console.Write("informe seu nome: ");
            nome = Console.ReadLine();
            Console.Write("informe sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("informe sua cidade: ");
            cidade = Console.ReadLine();
            Console.WriteLine("Nome: " + nome);
            Console.Write("Possui " + idade);
            Console.WriteLine(" anos");
            Console.WriteLine("mora em: " + cidade);
            Console.Write("pressione qualquer botão para fechar...");
            Console.ReadKey();
        }
    }
}
