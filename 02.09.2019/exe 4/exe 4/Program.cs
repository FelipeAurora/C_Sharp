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
            int x, y;
            Console.Write("Valor minimo: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Valor maximo: ");
            y = int.Parse(Console.ReadLine());
            while (x <= y)
            {
                if (x % 2 >= 1)
                {
                    Console.WriteLine(x);
                }
                x++;
            }

            Console.ReadKey();
        }
    }
}
