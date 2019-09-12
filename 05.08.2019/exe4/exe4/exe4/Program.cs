using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            float area,alt,b;

            Console.Write("Informe a base: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Infrme a altura: ");
            alt = float.Parse(Console.ReadLine());
            area = b * alt;
            Console.WriteLine("A área é = " + area);
            Console.Write("Pressione Uma tecla para fechar...");
            Console.ReadKey();
        }
    }
}
