using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, a, v;

            Console.Write("Informe o Raio: ");
            r = double.Parse(Console.ReadLine());
            Console.Write("Informe a Área: ");
            a = double.Parse(Console.ReadLine());

            v = (((3.14 * r) * r) * a);
            v = Math.Round(v, 1);

            Console.WriteLine("============================================");
            Console.WriteLine("O Volume é: " + v);
            Console.WriteLine("============================================");
            Console.ReadKey();
        }
    }
}
