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
            double c, n, e=0;
            string sair;
            do
            {
                Console.Clear();
                Console.Write("Informe seu código: ");
                c = double.Parse(Console.ReadLine());
                Console.Write("Horas de trabalho: ");
                n = double.Parse(Console.ReadLine());
                if (n <= 50)
                {
                    n *= 10;
                    e = 0;
                }
                else
                {
                    e = ((n - 50) * 20);
                    n = (50 * 10) + e;
                }
                e = Math.Round(e, 2);
                n = Math.Round(n, 2);
                Console.WriteLine("===============================================");
                Console.WriteLine("Salario : R$" + n);
                Console.WriteLine("Excedente : R$" + e);
                Console.WriteLine("===============================================");
                Console.Write("Deseja sair do programa ? <s/n> ");
                sair = Console.ReadLine();
                if (sair == "s")
                {
                }
            } while (sair == "n");
        }
    }
}
