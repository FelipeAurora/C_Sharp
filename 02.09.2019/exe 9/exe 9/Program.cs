using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int verifN = 0, verifP = 0, verifPA = 0, verifIM = 0;
            string sair;
            do
            {
                Console.Clear();
                for (int x = 1; x <= 10; x++)
                {
                    Console.Write("Informe o {0}° valor: ", x);
                    int valor = int.Parse(Console.ReadLine());
                    if (valor < 0)
                    {
                        verifN += 1;
                    }
                    if (valor >= 0)
                    {
                        verifP += 1;
                    }
                    if ( valor % 2 == 0)
                    {
                        verifPA += 1;
                    }
                    else
                    {
                        verifIM += 1;
                    }
                }
                Console.WriteLine("=================================================================");
                Console.WriteLine(verifN + " Número(s) Negativo(s)");
                Console.WriteLine(verifP + " Número(s) Positivo(s)");
                Console.WriteLine(verifPA + " Número(s) Par(es)");
                Console.WriteLine(verifIM + " Número(s) Ímpar(es)");
                Console.WriteLine("=================================================================");
                Console.WriteLine(" Deseja encerrar o programa ? <s/n>");
                sair = Console.ReadLine();
                if(sair == "s")
                {
                    Console.ReadKey();
                }
            }while ( sair == "n");
        }
    }
}
