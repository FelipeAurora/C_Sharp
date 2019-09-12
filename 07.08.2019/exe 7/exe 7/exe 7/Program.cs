using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;

            Console.Write("1º nome: ");
            nome1 = Console.ReadLine();
            Console.Write("2º Nome: ");
            nome2 = Console.ReadLine();
            Console.WriteLine("==============================================");
            Console.WriteLine(nome1.ToUpper());
            Console.WriteLine(nome1.Length);
            Console.WriteLine(nome1.Substring(0, 3));
            Console.WriteLine("==============================================");
            Console.WriteLine(nome2.ToUpper());
            Console.WriteLine(nome2.Length);
            Console.WriteLine(nome2.Substring(0, 3));
            Console.WriteLine("==============================================");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
