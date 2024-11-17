using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3_28_09_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //control structure
            //loops   {initilization, condition, updation}
            // while loop
            //do while loop
            // for loop
            // for each loop

            BikePrototype topvarint = new BikePrototype();
            //topvarint.Variant = "Top Varient";
            //topvarint.Color = "red";
            //topvarint.BikeDetails();
            topvarint.BikeDetails("Raider","Vijay");
            topvarint.BikeDetails(1000,"gokul");
            topvarint.BikeDetails();

            topvarint.bikeheight = 100;
            topvarint.Bikelength = 250;
            topvarint.displaytotalMeasurement();
            BikePrototype Middlevarint = new BikePrototype();
            //Middlevarint.Variant = "middle Varient";
            //Middlevarint.Color = "black";
            //Middlevarint.BikeDetails();
            Middlevarint.bikeheight = 150;
            Middlevarint.Bikelength = 350;
            Middlevarint.displaytotalMeasurement();

            //BikePrototype lowervarint = new BikePrototype();
            //lowervarint.Variant = "lower Varient";
            //lowervarint.Color = "yellow";
            //lowervarint.BikeDetails();
            //int returnvalue = lowervarint.addno();


            BikePrototype addedmeasurement = topvarint + Middlevarint;
            addedmeasurement.displaytotalMeasurement();


            //objopp.displaydata();
            //    string displaytesx = "";//string.Empty ;

            //    //if( displaytesx != null || displaytesx != "" )
            //    //{
            //    //    string newtext = displaytesx;
            //    //}else
            //    //{
            //    //    displaytesx = "new content";
            //    //}

            //    displaytesx = "hello world";

            //    Console.WriteLine(displaytesx);//10

            //    // while loop   ==> entry check loop
            //    //While Loop
            //    //A loop that continues as long as a condition is true.

            //    //int count = 0;//initilization

            //    // while (count < 10)//condition
            //    // {
            //    //     Console.WriteLine(displaytesx );
            //    //     count++;//updation
            //    // }

            //    //Do-While Loop //exit check loop
            //    //A loop that executes at least once, then continues while the condition is true.
            //    int x = 0;

            //    do
            //    {
            //        Console.WriteLine("Value of x: " + x);
            //        x++;
            //    } while (x < 3);

            //   // For Loop
            //     //A loop that repeats code a specific number of times.
            //      //    1        2     4
            //    for (int i = 0; i < 5; i++)
            //    {
            //        //3
            //        Console.WriteLine("Iteration: " + i);
            //    }

            //    //4.Foreach Loop
            //    //Used to iterate over collections such as arrays or lists.
            //    //fruits[0]= "Apple" 0        1         2        3          4
            //   string[] fruits = { "Apple", "Banana", "Cherry","grapes","jackfruit" };

            //    //list,array,hashtable,dataset,datatable

            //    //        
            //    foreach (string fruit in fruits)
            //    {
            //        Console.WriteLine(fruit);
            //    }

            //    int a = 10;

            //    //array

            //    //int[] numbers = new int[5]; // Array of integers with 5 elements (default values: 0)
            //    int[] arr = new int[5] { 10, 20, 30, 40, 50 };
            //    int[] numbers1 = new int[] { 1, 2, 3, 4, 5 };
            //    var numbers2 = new[] { 1, 2, 3, 4, 5 }; // The type is inferred to be int[]
            //    int[] numbers3 = { 1, 2, 3, 4, 5,6 }; // Implicitly initializes an array

            //    var dynamicvariable = "string";
            ////datatype variable     arary size
            //    int[] numbers = new int[5];




            //    Console.WriteLine("Please enter the array values");

            //    for(int arrayvaluesrow =0; arrayvaluesrow < 5; arrayvaluesrow++)//3
            //    {
            //        Console.WriteLine("Please enter the array values for inxed" + arrayvaluesrow);
            //        numbers[arrayvaluesrow] =Convert.ToInt32(Console.ReadLine());
            //        for (int arrayvaluescolumn = 0; arrayvaluescolumn < 5; arrayvaluescolumn++)//5
            //        {
            //            Console.WriteLine("Please enter the array values for inxed" + arrayvaluescolumn);
            //            numbers[arrayvaluescolumn] = Convert.ToInt32(Console.ReadLine());
            //        }
            //    }

            //    foreach(int displayvalues in numbers)
            //    {
            //        Console.WriteLine("the values are" + displayvalues);
            //    }


            //    // multidimenessional array
            //    int[,] matrix = new int[3, 3]; // Declares a 2D array (3 rows and 3 columns)
            //    //jagged array
            //    //A jagged array is an array of arrays, where each "row" can have a different length.

            //    int[][] jaggedArray = new int[3][]; // Declares a jagged array with 3 rows
            //    jaggedArray[0] = new int[] { 1, 2 }; // Initializes the first row
            //    jaggedArray[1] = new int[] { 3, 4, 5 }; // Initializes the second row
            //jaggedArray[2] = new int[] { 6 }; // Initializes the third row

            OOPS newobj = new OOPS();
            newobj.CallBikes();
            Console.ReadKey();

        }
    }
}
