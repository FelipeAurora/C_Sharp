using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, r,r1;
            Console.Write("Informe o valor de A:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de B:");
            b = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de C:");
            c = int.Parse(Console.ReadLine());
            r1 = Math.Pow(a, 2);
            r = r1 * 5 – c / (b – a % 4);
            Console.WriteLine("O resultado é:" + r);
            Console.WriteLine("Pressione qualquer tecla para fechar");
            Console.ReadKey();
        }
    }
}
