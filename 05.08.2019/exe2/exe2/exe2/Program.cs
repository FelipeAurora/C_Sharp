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
            float v1, v2, soma, div, sub, mul;

            Console.Write("Digite o 1° valor:");
            v1 = float.Parse(Console.ReadLine());
            Console.Write("Digite um 2° valor");
            v2 = float.Parse(Console.ReadLine());
            soma = v1 + v2;
            sub = v1 - v2;
            div = v1 / v2;
            mul = v1 * v2;
            Console.WriteLine("A Soma:" + soma);
            Console.WriteLine("A Subtração:" + sub);
            Console.WriteLine("A Multiplicação:" + mul);
            Console.WriteLine("A Divisão:" + div);
            Console.Write("Pressione Qualquer tecla para fechar o programa...");
            Console.ReadKey();
        }
    }
}
