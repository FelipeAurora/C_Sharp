﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 11;

            while (x < 250)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
                x++;
            }

            Console.ReadKey();
        }
    }
}
