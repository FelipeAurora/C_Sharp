using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;

            Console.Write("Informe o valor em Firenheith: ");
            f = double.Parse(Console.ReadLine());

            c = ((f - 32) * 5) / 9;
            c = Math.Round(c, 1);

            Console.WriteLine("=======================================");
            Console.WriteLine("Em Celsus: " + c + " C° ");
            Console.WriteLine("=======================================");
            Console.ReadKey();
        }
    }
}
