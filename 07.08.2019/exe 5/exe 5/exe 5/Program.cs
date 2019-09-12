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
            int idade;

            Console.WriteLine("Informe sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("===================================================");
            Console.WriteLine(idade >= 18 ? "Você é Maior De idade" : "Você é Menor de idade");
            Console.WriteLine("===================================================");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
