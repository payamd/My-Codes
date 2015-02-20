using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Car payamCar = new Car();
            payamCar.Name = "maclaren";
            payamCar.Model = "p1";
            payamCar.Color="red";
            payamCar.Year = 1978;



            Truck myTruck = new Truck();
            myTruck.Model="daff-90";
            myTruck.Name = "daff";
            myTruck.Color = "orange";
            myTruck.Year=1987;
            myTruck.bar = 5000;





            ShowMyCar(payamCar);
            ShowMyCar(myTruck);
            Console.ReadLine();

        }
        private static void ShowMyCar(Car car) {
         
        Console.WriteLine("your car is ready sir !!" + car.FormatMe());
        
        }

       

    }

    class Car {
        
        public String Name { get; set; }
        public String Model { get; set; }
        public String Color { get; set; }
        public int Year { get; set; }


        public virtual string FormatMe() 
        { return String.Format("{0} - {1} - {2} - {3}",this.Name,this.Model,this.Year,this.Color); } 

             }

    class Truck : Car {
        public int bar { get; set; }

         public override string FormatMe() 
        { return String.Format("{0} - {1} - {2} ",this.Name,this.Model,this.bar); } 

             }

    }
