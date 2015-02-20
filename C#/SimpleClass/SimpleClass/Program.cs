using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car payamscar = new Car();
            payamscar.name = "bmw";
            payamscar.model = "750li";
            payamscar.year = 2015;
            payamscar.color = "black";


            //===================================================
            Console.WriteLine(payamscar.name + " "+ payamscar.model+ " "+payamscar.year
                +" "+payamscar.color);
            Console.ReadLine();
           //====================================================



        }
    }

    class Car {

        public string name { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string color { get; set; }

    
    }
}
