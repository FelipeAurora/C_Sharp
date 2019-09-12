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

            int anoA, anoN, diaA, diaN, mesA, mesN, all;

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

            if (diaA < diaN)
                all = diaN - diaA;
            else
                all = diaA - diaN;

            if (mesA < mesN)
                all = all + ((mesN - mesA) * 30);
            else
                all = all + ((mesA - mesN) * 30);

            all = all + ((anoA - anoN) * 365);

            Console.WriteLine("=================================================================");
            Console.WriteLine("Você possui " + all + " dias de vida");
            Console.WriteLine("=================================================================");
            Console.WriteLine("Pressione qualquer tecla para fechar");
            Console.ReadKey();
        }
    }
}
