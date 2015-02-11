using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //int y;
            //x = 7;
            //y = x + 3;
            //Console.WriteLine(y);
            //string myFirstName;
            int payam = 7;
            var q = payam.ToString();
            Console.WriteLine(q);
            int z=3 + int.Parse(q);
            var myFirstName = "Payam";
            Console.WriteLine(myFirstName);
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
