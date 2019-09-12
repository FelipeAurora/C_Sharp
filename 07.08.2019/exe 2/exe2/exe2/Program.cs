using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Dê um valor: ");
            num = int.Parse(Console.ReadLine());
            num = num * 2;
            Console.WriteLine("O Resultado é: " + num);
            Console.Write("pressione uma tecla para fechar...");
            Console.ReadKey();
        }
    }
}
