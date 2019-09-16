using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, numMax, x;
            Console.Write("Digite a 1° nota: ");
            numMax = double.Parse(Console.ReadLine());
            for (x = 1; x <= 9; x++)
            {
                do
                {
                    Console.Write("Digite a {0}° nota: ", x + 1);
                    num = double.Parse(Console.ReadLine());
                    if (num >= 0 && num <= 10)
                    {
                        numMax = numMax + num;
                    }
                    else
                    {
                        Console.WriteLine("Nota Invalida");
                    }
                }
                while (num < 0 || num > 10);
            }
            numMax = numMax / 10;
            Console.WriteLine("Sua média é: "+numMax);
            Console.ReadKey();
        }
    }
}
