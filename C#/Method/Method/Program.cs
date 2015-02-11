using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        anghozi a =new anghozi();
    //        Console.WriteLine( a.ghermezi());
    //        Console.Read();

    //    }

    //}

    //class anghozi { 
    //public string ghermezi(){
    //    return "hello world";
    //}
    //}\

//    class Program
//    {
//        static void Main(string[] args)
//        {


//            anghozi sag = new anghozi();

//            Console.WriteLine(anghozi.ghermezi());
//            sag.SetPayam("\n I am Payam And you ?\n");
//            Console.WriteLine(sag.GetPayam());
//            Console.Read();

//        }

//    }

//    class anghozi
//    {

//        private string payam;

//        public string GetPayam()
//        {
//            return this.payam;
//        }
//        public void SetPayam(string val)
//        {
//            this.payam = val;
//        }

//        public static string ghermezi()
//        {
//            return "hello world";
//        }
//    }
//}


    class Program
    {
        static void Main(string[] args)
        {


            anghozi sag = new anghozi();

            Console.WriteLine(anghozi.ghermezi());
            sag.SetPayam("\nI am Payam And you ?\n");
            Console.WriteLine(sag.GetPayam());
            Console.Read();

        }

    }

    abstract class apayam
    {
        public abstract string run();
    }


    class anghozi : apayam
    {
        public override string run()
        {
            return "";
        }
        private string payam;

        public string GetPayam()
        {
            return this.payam;
        }
        public void SetPayam(string val)
        {
            this.payam = val;
        }

        public static string ghermezi()
        {
            return "hello world";
        }
    }
}

