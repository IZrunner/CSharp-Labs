using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vehicle
    {
        //protected string title;
        public int horsePower;
        public int capacity;       

        public Vehicle()
        {
            //this.title = "Plotwa"; 
            this.horsePower = 1; this.capacity = 3;
        }

        public Vehicle(int setHP)
        {
            this.horsePower = setHP;
        }

        public Vehicle(int setHP, int setCapacity)
        {
            //this.title = setTitle; 
            this.horsePower = setHP; this.capacity = setCapacity;
        }

        public static Vehicle operator - (Vehicle x, Vehicle y)
        {
            Vehicle sampleObj = new Vehicle();
            sampleObj.horsePower = x.horsePower - y.horsePower;
            return sampleObj;
        }

        public static Vehicle operator + (Vehicle x, int requiredVal)
        {
            Vehicle sampleObj = new Vehicle();
            sampleObj.capacity = x.capacity + requiredVal;
            return sampleObj;
        }

        public static Vehicle operator -- (Vehicle x)
        {
            Vehicle sampleObj = new Vehicle();
            sampleObj.horsePower = x.horsePower;
            sampleObj.horsePower --;            
            return sampleObj;
        }

        public static implicit operator Vehicle(int x)
        {
            return new Vehicle(x);
        }

        public static explicit operator Int32(Vehicle x)
        {
            return x.horsePower;
        }

        public string MoveOn()
        {
            return "Move on, Plotwichka!";
        }

        //public virtual void ShowWholeData()
        //{
        //    Console.WriteLine("Show scpecifications below : ");
        //    Console.WriteLine($"Title : {this.title} " +
        //        $"\nHorse Power : {this.horsePower}" +
        //        $"\nCapacity : {this.capacity} \n");
        //}

        



        ~Vehicle()
        {
            Console.WriteLine("RIP Bucephalus (");
        }

    }
}
