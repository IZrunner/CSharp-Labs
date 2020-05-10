using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SomeA
    {
        public int firstVal;
        public int secondVal;


        public SomeA()
        {
            this.firstVal = 10; this.secondVal = 12;
        }
        public SomeA(int first, int second)
        {
            this.firstVal = first; this.secondVal = second;
        }       

        public void ShowDay(WeekDays someDay)
        {
            Console.WriteLine(someDay);
        }
    }
}
