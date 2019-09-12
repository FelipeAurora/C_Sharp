using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max, med;

            Console.Write("Informe a quantidade mínima: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade média: ");
            max = int.Parse(Console.ReadLine());

            med = (min + max) / 2;
            Console.WriteLine("===================================================");
            Console.WriteLine("Possui em média " + med + "unidades");
            Console.WriteLine("===================================================");
            Console.WriteLine("Pressione qualquer tecla para saír...");
            Console.ReadKey();
        }
    }
}
