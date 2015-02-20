using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
          //  string date = DateTime.Now.ToString();
            DateTime date = DateTime.Now;
           // Console.WriteLine(date.ToShortDateString());
          //  Console.WriteLine(date.ToShortTimeString());
            Console.WriteLine(date.ToLongDateString());
            Console.WriteLine(date.AddDays(5).ToLongDateString());
            Console.WriteLine(date.ToLongTimeString());
            Console.WriteLine(date.AddHours(3).ToLongTimeString());

            Console.ReadLine();
        }
    }
}
