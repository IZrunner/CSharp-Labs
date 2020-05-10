using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Train : Vehicle
    {
        protected int trucks;
        new public int someVarToBeKilledByNewKeyword = 789;

        public Train()
        {
            this.title = "Little Engine That Could"; this.horsePower = 12000; this.capacity = 345; this.trucks = 67;
        }

        public Train(string setTitle, int setHP, int setCapacity, int setTrucks) : base(setTitle, setHP, setCapacity)
        {
            this.title = setTitle; this.horsePower = setHP; this.capacity = setCapacity; this.trucks = setTrucks;
        }

        new public void ShowKilledVar()
        {
            Console.WriteLine($"Killed value is {this.someVarToBeKilledByNewKeyword}");
        }


        ~Train()
        {
            Console.WriteLine("RIP Bucephalus Train ((");
        }
    }
}
