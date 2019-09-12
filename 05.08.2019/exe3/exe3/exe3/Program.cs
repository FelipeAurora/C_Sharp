using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade, anoN, anoAt;

            Console.Write("Digite seu nome:");
            nome = Console.ReadLine();
            Console.Write("Digite o Ano em que você nasceu:");
            anoN = int.Parse(Console.ReadLine());
            Console.Write("Informe O Ano em que Você está:");
            anoAt = int.Parse(Console.ReadLine());
            idade = anoAt - anoN;
            Console.Write(nome + " você tem " + idade);
            Console.WriteLine(" anos");
            Console.WriteLine("Pressione qualquer tecla para fechar o programa...");
            Console.ReadKey();
        }
    }
}
