using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please enter something here!!!");
            //string userValue = Console.ReadLine();
            //Console.WriteLine("you entered: " + userValue);
            //Console.ReadLine();


            Console.WriteLine("please Select from 1 , 2 or 3!");
            string userValue = Console.ReadLine();
            if (userValue == "2") {
                Console.WriteLine("you won a new car!! bugati veyron!");
                Console.ReadLine();

            }
            else if (userValue == "1")
            {
                Console.WriteLine("you won a new cat!!");
                Console.ReadLine();
            
            }
            else if (userValue == "3")
            {
                Console.WriteLine("you won a new boat!!");
                Console.ReadLine();

            }
            else { 
            Console.WriteLine("you won nothing dear !");
            Console.ReadLine();

            }
        }
    }
}
