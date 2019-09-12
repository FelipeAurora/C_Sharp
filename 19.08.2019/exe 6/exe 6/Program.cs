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

            string nome;
            int anoA, anoN, diaA, diaN, mesA, mesN, all;
            float idade, f;

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("=================================================================");
            Console.Write("Informe o Ano em que você nasceu: ");
            anoN = int.Parse(Console.ReadLine());
            Console.Write("Informe o Mês em que você nasceu: ");
            mesN = int.Parse(Console.ReadLine());
            Console.Write("Informe o Dia em que você nasceu: ");
            diaN = int.Parse(Console.ReadLine());
            Console.WriteLine("=================================================================");
            Console.Write("Informe o Ano Atual: ");
            anoA = int.Parse(Console.ReadLine());
            Console.Write("Informe o Mês Atual: ");
            mesA = int.Parse(Console.ReadLine());
            Console.Write("Informe o Dia Atual: ");
            diaA = int.Parse(Console.ReadLine());


            all = diaA - diaN;

            all = all + ((mesA - mesN) * 30);

            all = all + ((anoA - anoN) * 365);

            idade = (all / 365);
            Math.Floor(idade);
            f = 18 - idade;
            Math.Floor(f);

            Console.WriteLine("=================================================================");
            if (idade >= 18)
                Console.WriteLine(nome + " você está apto para tirar carteira demotorista.");
            else
                Console.WriteLine("FALTAM " + f + " ANOS PARA PODER TIRAR A CARTEIRA DE MOTORISTA!.");

            Console.WriteLine("=================================================================");
            Console.WriteLine("Pressione qualquer tecla para fechar");
            Console.ReadKey();
        }
    }
}
