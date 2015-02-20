using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Works__with_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string payam = "hello this is payam :)";
            StringBuilder moosh = new StringBuilder();
   //        payam = payam.Substring(4,10);
  //         payam = payam.ToUpper();
 //          payam = payam.Trim();
            
            //for (int i = 0; i < 200; i++)
            //{
            //    moosh.Append("*");
            //    moosh.Append(i);
            //}

            //   Console.WriteLine(moosh);
           //  Console.WriteLine(payam);
//         \\
        
            payam = payam.Replace("i", "!");
            Console.WriteLine(payam);
            Console.ReadLine();
        }
    }
}
