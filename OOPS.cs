using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Session3_28_09_2024
{
    internal class OOPS
    {
        //oops => object oriented programming
        //Encapusalation
        //polimorphisim
        //inheritance
        //abstraction
        //interface


        /*Procedural programming is about writing procedures or methods that perform operations on the data, while object-oriented programming is about creating objects that contain both data and methods.

        Object-oriented programming has several advantages over procedural programming:

        OOP is faster and easier to execute
        OOP provides a clear structure for the programs
        OOP helps to keep the C# code DRY "Don't Repeat Yourself", and makes the code easier to maintain, modify and debug
        OOP makes it possible to create full reusable applications with less code and shorter development time
        Tip: The "Don't Repeat Yourself" (DRY) principle is about reducing the repetition of code. You should extract out the codes that are common for the application, and place them at a single place and reuse them instead of repeating it.*/


        //> Encapsulation is defined as the wrapping up of data and information under a single unit. 

        //polimorphisim
        /*It allows objects of different types to be treated as instances of a common base type,
         making code more flexible and reusable.*/
        //runtime polimorphism

        //Compile Polimorphism
        //Method Overloading
        //You can have multiple methods in the same class with the same name but different parameter lists (types or number of parameters).
        //operoverloading


        //runtime polimorphism
        //method Overriding

        //Inheritance
        //single inheritance //one base clase inherited by one child class
        //Hierarchical inheritance //one base clase inherited by multiple child class
        //multilevel inheritance //gchild inherit father and father inherit grand father
        //multiple inheritance  // one child class inheritted from multiple base class (not supported) //but we can achieve by interface
        //hybrid inheritance  // single inheritance and multilevel inheritance

        public void CallBikes()
        {
            BIkes tvsbike = new TVS();
            bikedetailsabstract hondabike = new Honda();

            tvsbike.Specs();  // Outputs: "The dog barks."
            hondabike.Specs();
        }


    }

    interface centeralbikedetails
    {
        void Bikespecc();
       void DisplaySSpec();

    }
    interface statebikedetails2
    {
        void Bikespecstate();
        void DisplaySSpecstate();

    }

    public abstract class bikedetailsabstract
    {
        // Abstract method (does not have implementation)
        public abstract void Bikespecnew();

        public virtual void Specs()
        {

        }
        // Regular method with implementation
        public void normalmethod()
        {
            Console.WriteLine("The animal is sleeping.");
        }
    }
    public class BIkes
    {
        
        public string name = "alice";
        public virtual void Specs()
        {
            Console.WriteLine("Having 2 Wheesls,1 Head light, 2 Mirror"); 
        }
    }

    public class newbike
    {
        public virtual void newSpecs()
        {
            Console.WriteLine("Having 2 Wheesls,1 Head light, 2 Mirror");
        }

    }

    public class TVS : BIkes
    {
        public string vehname = "TVS";
        public override void Specs()
        {
            base.Specs();
            Console.WriteLine("Having CVTI braking System");
        }

        public void TVSspecs()
        {

        }
    }

    public class Honda : bikedetailsabstract
    {
        public override void Specs()
        {
            Console.WriteLine("Honda Having Combi brakes");
        }
        public override void Bikespecnew()
        {

        }
    }
    public class Bajaj : centeralbikedetails, statebikedetails2
    {
        public void Bikespecstate()
        {
            
        }

        public void DisplaySSpecstate()
        {
            
        }

        public  void Specs()
        {
            Console.WriteLine("Having alloy wheels");
        }


        void centeralbikedetails.Bikespecc()
        {
           
        }

        void centeralbikedetails.DisplaySSpec()
        {
            
        }
    }



    public class suzuki : TVS
    {
        public override void Specs()
        {
            
            Console.WriteLine("Having CVTI braking System"+ base.name + base.vehname);
        }

    }

}
