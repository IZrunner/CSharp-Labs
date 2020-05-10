using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Auto : Vehicle
    {
        protected int doors;
        new public int someVarToBeKilledByNewKeyword = 456;

        public Auto()
        {
            this.title = "Rickshaw"; this.horsePower = 1; this.capacity = 2; this.doors = 4;
        }

        public Auto(string setTitle, int setHP, int setCapacity, int setDoors) : base(setTitle, setHP, setCapacity)
        {
            this.title = setTitle; this.horsePower = setHP; this.capacity = setCapacity; this.doors = setDoors;
        }

        public void ShowInstruction()
        {
            Console.WriteLine("Imagine this is the instruction");
        }

        new public void ShowKilledVar()
        {
            Console.WriteLine($"Killed value is {this.someVarToBeKilledByNewKeyword}");
        }

        public override void ShowWholeData()
        {
            Console.WriteLine("Show scpecifications below : ");
            Console.WriteLine($"Title : {this.title} " +
                $"\nHorse Power : {this.horsePower}" +
                $"\nCapacity : {this.capacity} " +
                $"\nDoors : {this.doors}\n");
        }

        public void TetsMethodAuto(Vehicle blueprintVehicle)
        {
            blueprintVehicle = new Auto(); // Creating instance of extended and implicit up-cast it to base
            Auto nextGenCar = (Auto)blueprintVehicle; // Down-cast of the reference stored in "baseObj" to the extended obj.
            nextGenCar.ShowInstruction();
        }




        ~Auto()
        {
            Console.WriteLine("RIP Bucephalus Auto (((");
        }
    }
}
