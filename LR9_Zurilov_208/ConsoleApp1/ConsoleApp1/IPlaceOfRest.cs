using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IPlaceOfRest
    {
        string SetCoordinates { get; set; }
        float ComputeExpenses();
        void ShowAds();
        int SetMaxCrowd { get; set; }
    }
}
