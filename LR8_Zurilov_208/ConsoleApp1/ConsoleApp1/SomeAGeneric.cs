using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SomeAGeneric<anyType> 
    {
        private anyType firstVal; //unable to set the default value in C# 7.0
        private anyType secondVal;


        //public SomeAGeneric()
        //{
        //    this.firstVal = default; this.secondVal = default;
        //}

        public SomeAGeneric(anyType first, anyType second)
        {
            this.firstVal = first; this.secondVal = second;
        }

        public void WhateverItDoes <anyType>(SomeAGeneric<anyType> objSample, anyType xValue, anyType yValue)
        {
            Console.WriteLine("Before manipulations: " + objSample.firstVal + objSample.secondVal);
            objSample.firstVal = xValue;
            objSample.secondVal = yValue;
            Console.WriteLine("Check the changes: " + objSample.firstVal + objSample.secondVal);
        }
    }
}
