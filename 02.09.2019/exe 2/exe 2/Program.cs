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
            int x, y;
            Console.Write("Valor minimo: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Valor maximo: ");
            y = int.Parse(Console.ReadLine());
            while (y >= x)
            {
                if (y % 2 >= 1)
                {
                    Console.WriteLine(y);
                }
                y--;
            }

            Console.ReadKey();
        }
    }
}
