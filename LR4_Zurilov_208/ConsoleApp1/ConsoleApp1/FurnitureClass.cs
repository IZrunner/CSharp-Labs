using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FurnitureClass
    {
        static string reservedTitle;
        static FurnitureClass()
        {
            reservedTitle = "default";
            Console.WriteLine($"Once called, reserved title is {reservedTitle}\n");
        }

        private string title;
        private int amount;
        private double price;
        public const int reservedAmount = 5000;
        public readonly int legs;

        public FurnitureClass()
        {
            Console.WriteLine("It's the default constructor, there's nothing here");
        }

        public FurnitureClass(string Title, int Amount, double Price)
        {
            title = Title;
            amount = Amount;
            price = Price;
            legs = 4;
        }

        public void ReadThatCopiedArray(int[] arr) // reference type + value parameter
        {
            int searchValue = 1;
            int index = Array.IndexOf(arr, searchValue);
            Console.WriteLine("Length of this dimension of representd array is {0}", arr.GetLength(0)); //1-st method
            Console.WriteLine("Values on 1-st and 2-nd positions int this array are {0} and {1}", arr.GetValue(0), arr.GetValue(1)); //2-nd method
            Console.WriteLine($"The index of a searched value '{searchValue}' in the array is '{index}'");
        }

        public void TransformCopy(int someVal) // value type + value parameter
        {
            Console.WriteLine($"Add 660 to it : {someVal += 660}");
        }

        static public void FixTheSameObject(ref FurnitureClass actualObject) // reference parameter
        {
            actualObject = new FurnitureClass("sofa", 12, 34);
            Console.WriteLine($"New title of chair is '{actualObject.title}', new amount is '{actualObject.amount}', new price is '{actualObject.price}'");
        }

       static public void CreateBrandNewObject(out FurnitureClass newObject)
       {
            newObject = new FurnitureClass("smth", 67, 89);
            Console.WriteLine($"New title is {newObject.ChangeTitle = "Pillar"}");
       }

        public void RandomEnumeration(int x = 4, int y = 5, params int[] z)
        {
            Console.WriteLine($"Default values are '{x}' and '{y}'");
            foreach(int i in z)
            {
                Console.WriteLine("Element of array = " + i);
            }
        }
        
        public void UnkeptEnumeration(int someOne, int someTwo, int someThree)
        {
            Console.WriteLine($"This values are '{someOne}' , '{someTwo}' and '{someThree}'");
        }

        public double PriceInDollars
        {
            set { price = value; }
            get { return price / 28; }
        }

        public string ChangeTitle
        {
            set { title = value; }
            get { return title; }
        }

        public static string ChangeSmth
        {
            get; set;
        }

        public int GetLegs()
        {
            return legs;
        }










        ~FurnitureClass()
        {
            Console.WriteLine("See you, space cowboy");
        }
    }
}