﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++) { Console.WriteLine(i);
            if (i == 8) { Console.WriteLine("We found 8 !!!! hooora");
            break;
            }

            }
            Console.ReadLine();


        }
    }
}
