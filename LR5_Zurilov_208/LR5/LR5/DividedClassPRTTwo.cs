using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    partial class DividedClassPRTOne
    {
        public void GetValues()
        {
            Console.WriteLine($"1-st is {someNumOne}, 2-nd is {someNumTwo}");            
        }

        ~DividedClassPRTOne()
        {
            Console.WriteLine("Let this object go");
        }
    }
}
