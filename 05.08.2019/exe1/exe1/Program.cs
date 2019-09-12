using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, r;

            Console.Write("Digite o 1° valor:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2° valor:");
            b = double.Parse(Console.ReadLine());
            r = a + b;
            Console.WriteLine("O resultado da soma é:" + r);
            Console.Write("Pressione qualquer tecla para fechar o programa...");
            Console.ReadKey();
        }
    }
}
