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
            double real, dolar, r;

            Console.Write("Informe a cotação do Dolar: ");
            dolar = double.Parse(Console.ReadLine());
            Console.Write("Qual valor dessa converter (Em R$): ");
            real = double.Parse(Console.ReadLine());

            r = real / dolar;
            r = Math.Round(r, 2);

            Console.WriteLine("============================================");
            Console.WriteLine("Você terá um total de " + r + " Dolares");
            Console.WriteLine("============================================");
            Console.WriteLine("Pressione qualquer tecla pra sair...");
            Console.ReadKey();
        }
    }
}
