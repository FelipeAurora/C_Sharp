using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, x, r;
            Console.Write("De o Fatorial: ");
             n = double.Parse(Console.ReadLine());
            r = n;
            for (x = n - 1; x > 1; x--)
            {
                r = r * x;
            }
            Console.WriteLine("=============================================================");
            Console.WriteLine("Resultado = "+r);
            Console.ReadKey();
        }
    }
}
