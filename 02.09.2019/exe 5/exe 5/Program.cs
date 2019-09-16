using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, numMax, x;
            Console.Write("Digite o 1° número:");
            numMax = int.Parse(Console.ReadLine());
            for(x = 1; x <= 15; x++)
            {
                Console.Write("Digite o {0}° número" x+1);
                num = int.Parse(Console.ReadLine());
                if (num > numMax)
                {
                    numMax = num;
                }                
            }
            Console.WriteLine("O maior número foi {0}", num);
            Console.ReadKey();
        }
    }
}
