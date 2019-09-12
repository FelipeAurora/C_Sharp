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
            double r, d, e;

            Console.Write("Informe a cotação do Dolar: ");
            d = double.Parse(Console.ReadLine());
            Console.Write("Informe a cotação do Euro: ");
            e = double.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de dinheiro que deseja converter (R$): ");
            r = double.Parse(Console.ReadLine());

            d = r / d;
            d = Math.Round(d, 2);
            e = r / e;
            e = Math.Round(e, 2);
            Console.WriteLine("==============================================================================");
            Console.WriteLine("Terá " + d + " Dolares.");
            Console.WriteLine("Ou " + e + " Euros.");
            Console.WriteLine("==============================================================================");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
