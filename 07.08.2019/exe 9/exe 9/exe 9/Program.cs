using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Informe o valor A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor B: ");
            b = int.Parse(Console.ReadLine());

            c = a;
            a = b;
            b = c;
            Console.WriteLine("==================================================");
            Console.WriteLine("Variavel A: " + a);
            Console.WriteLine("Variavel B: " + b);
            Console.WriteLine("==================================================");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
