using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vehicle
    {
        protected string title;
        protected int horsePower;
        protected int capacity;
        public int someVarToBeKilledByNewKeyword = 123;

        public Vehicle()
        {
            this.title = "Plotwa"; this.horsePower = 1; this.capacity = 3;
        }      

        public Vehicle(string setTitle, int setHP, int setCapacity)
        {
            this.title = setTitle; this.horsePower = setHP; this.capacity = setCapacity;
        }

        public void ShowKilledVar()
        {
            Console.WriteLine($"Killed value is {this.someVarToBeKilledByNewKeyword}");
        }

        public string MoveOn()
        {
            return "Move on, Plotwichka!";
        }

        public virtual void ShowWholeData()
        {
            Console.WriteLine("Show scpecifications below : ");
            Console.WriteLine($"Title : {this.title} " +
                $"\nHorse Power : {this.horsePower}" +
                $"\nCapacity : {this.capacity} \n");
        }

        public static void TetsMethodVehicle(Object blueprintObj)
        {
            if(blueprintObj != null)
            {
                Vehicle transformTo = blueprintObj as Vehicle;
                    if (transformTo is Vehicle)
                    {
                        Console.WriteLine(transformTo.MoveOn());
                    }
                    else
                    {
                        Console.WriteLine("NullPtrException");
                    }
            }                      
        }



        ~Vehicle()
        {
            Console.WriteLine("RIP Bucephalus (");
        }

    }
}
