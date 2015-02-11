using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromTxT
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader p = new StreamReader("TXT.txt");
            string line = "";
            while (p != null)
            {
                line = p.ReadLine();
                if (line != null)
                {

                    
                    Console.WriteLine(line);
                }
            }
            Console.ReadLine();
        }
    }
}
