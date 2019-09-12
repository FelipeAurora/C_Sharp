using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            Console.Write("Temperatura (C°) ? ");
            c = double.Parse(Console.ReadLine());

            f = ((9 * c) + 160) / 5;

            Console.WriteLine("==========================================");
            Console.WriteLine("Em Farenheit: " + f + "F° ");
            Console.WriteLine("==========================================");
            Console.ReadKey();
        }
    }
}
