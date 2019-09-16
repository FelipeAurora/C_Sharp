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
            int x, y;
            Console.Write("De o valor da tabuada: ");
            y = int.Parse(Console.ReadLine());
            for (x = 0; x <= 10; x++)
            {
                Console.Write(x + " * " + y + " = ");
                    Console.WriteLine(x * y);
                
            }
            Console.ReadKey();
            
        }
    }
}
