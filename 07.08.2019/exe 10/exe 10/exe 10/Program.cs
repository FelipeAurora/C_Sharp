using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, x, y, z;
            bool r;

            Console.Write("Informe o valor de W: ");
            w = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de Y: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de Z: ");
            z = int.Parse(Console.ReadLine());

            r = (x >= y) && (z <= x) || (x == w) && (y == z) || (!(x != w));

            Console.WriteLine("===============================================================");
            Console.WriteLine("Ordem Decrescente: " + r);
            Console.WriteLine("===============================================================");
            Console.WriteLine("Pressione qualquer botão para sair...");
            Console.ReadKey();
        }
    }
}
