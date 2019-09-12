using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.Write("Dê o número: ");
            num = double.Parse(Console.ReadLine());
            numx = Math.Pow(+num,2);
            Console.WriteLine("O Resultado é: " + num);
            Console.WriteLine("Pressione uma tecla para fechar...");
            Console.ReadKey();
        }
    }
}
