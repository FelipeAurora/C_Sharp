using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe5
{
    class Program
    {
        static void Main(string[] args)
        {
            float num, resul;

            Console.Write("Qual Tabuada deseja ?");
            num = float.Parse(Console.ReadLine());
            resul = num;
            Console.WriteLine(num + " * 1 = " + resul);
            resul = num * 2;
            Console.WriteLine(num + " * 2 = " + resul);
            resul = num * 3;
            Console.WriteLine(num + " * 3 = " + resul);
            resul = num * 4;
            Console.WriteLine(num + " * 4 = " + resul);
            resul = num * 5;
            Console.WriteLine(num + " * 5 = " + resul);
            resul = num * 6;
            Console.WriteLine(num + " * 6 = " + resul);
            resul = num * 7;
            Console.WriteLine(num + " * 7 = " + resul);
            resul = num * 8;
            Console.WriteLine(num + " * 8 = " + resul);
            resul = num * 9;
            Console.WriteLine(num + " * 9 = " + resul);
            resul = num * 10;
            Console.WriteLine(num + " * 10 = " + resul);
            Console.Write("Pressione uma tecla para fechar o programa...");
            Console.ReadKey();
        }
    }
}
