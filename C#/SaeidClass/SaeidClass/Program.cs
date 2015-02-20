using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaeidClass
{
    class Program
    {
        static void Main(string[] args)
        {

            b payam = new b();
            payam.display();
            Console.ReadLine();



            a test = new a();
            test.payam = 1000;
            //=================
            a saeed = test;
            saeed.payam = 5000;
            Console.WriteLine(test.payam);
            Console.ReadLine();

        }
    }


    class a {

        public int payam { get; set; }

        public void display()
        {
            Console.WriteLine("here is class a");
        }
    }


    class b:a
    {
        public void display()
        {
            base.display();
            Console.WriteLine("here is class b");
        }
    }



}
