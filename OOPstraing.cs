using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3_28_09_2024
{
    //acces modifiers
    //public
    //private
    //internal
    //protected

    class BikePrototype
    {
        //class members or field or properties
        public string Name = "TVS Raider";
        public string Variant;//3
        public string Color;//5
        public static int BikeCount;
        public const int vehicleCC = 125;

        public int Bikelength;
        public int bikeheight;

        //constructor
        //default constructor
        public BikePrototype()
        {
            BikeCount++;
            Console.WriteLine("No of bike produced" + BikeCount);
        }
        //parameterized constructor
        //static constructor
        //methods or functions

        //methods
        internal void BikeDetails()
        {
            Console.WriteLine("Variant of the Bike  " + Variant);
            Console.WriteLine("Color of the Bike " + Color);
        }

        internal void BikeDetails(string Price, string CustomerName)//based on parameters
        {
            Console.WriteLine("Variant of the Bike  " + Variant);
            Console.WriteLine("Color of the Bike " + Color);
            Console.WriteLine("Color of the price " + Price);
        }

        //internal void BikeDetails(string bikeNmae, string CustomerName)
        //{
        //    Console.WriteLine("Variant of the Bike  " + Variant);
        //    Console.WriteLine("Color of the Bike " + Color);
        //    Console.WriteLine("Color of the bikeNmae " + bikeNmae);
        //}
        internal double BikeDetails(int Price, string CustomerName) // parameter data type based
        {
            Console.WriteLine("Variant of the Bike  " + Variant);
            Console.WriteLine("Color of the Bike " + Color);
            Console.WriteLine("Color of the price " + Price);

            return 10.25;
        }

        public int addno()
        {
            return 10 + 20;
        }


        public static BikePrototype operator +(BikePrototype obj1, BikePrototype obj2)
        {
            int length = obj1.Bikelength + obj2.Bikelength;
            int height = obj1.bikeheight + obj2.bikeheight;
            return new BikePrototype
            {
                Bikelength = length,
                bikeheight = height
            };
        }


        public void displaytotalMeasurement()
        {
            Console.WriteLine("Length :" + Bikelength + "Height :" + bikeheight);
        }

    }

    static class sparesList
    {
        static public string sparename = "Fuel tank";

        public static void displaySpareName()
        {
            Console.WriteLine("The Spare Name Is :" + sparename);
        }
    }
}
