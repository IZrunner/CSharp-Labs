using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
    public class FurnitureAmountClass
    {
        public int trueAmount { get; set; }
    }
    */

    public class FurnitureClass
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

        public int[] customAmountX = new int[5];
        public int[] customAmountY = new int[5];
        private int targetAmountX;
        private int targetAmountY;

        /*
        FurnitureAmountClass[] setOfAmounts;
        public People()
        {
            setOfAmounts = new FurnitureAmountClass[5];
        }

        //Indexer
         public FurnitureAmountClass this[int index]
         {
            get
            {
                return setOfAmounts[index];
            }
            set
            {
                setOfAmounts[index] = value;
            }
         }
         */

        public int this[int targetIndex]
        {
            get
            {
                switch (targetIndex  % 2 == 0)
                {                   
                    case true: return customAmountX[targetIndex];
                    case false: customAmountY[targetIndex] = targetAmountY;                       
                    default: return null;                 
                }
            }
            set
            {
                switch (targetIndex  % 2 == 0) 
                {                           
                    case true:
                        customAmountX[targetIndex] = targetAmountX;
                        break;
                    case false:
                        customAmountY[targetIndex] = targetAmountY;
                }
            }
   



        public FurnitureClass()
        {
            Console.WriteLine("It's the default constructor, there's nothing here");
        }

        public FurnitureClass(string Title, int Amount, double Price)
        {
            title = Title;
            amount = Amount;
            price = Price;
        }

        public double PriceInDollars
        {
            set { price = value; }
            get { return price / 28; }
        }

        public string ChangeTitle
        {
            get; set;
        }

        public static string ChangeSmth
        {
            get; set;
        }

        /*
        public double[] customAmount = new double[5];
        private double x;
        private double y;
        public double this[int i]
        {
            get => customAmount[i];
            set => customAmount[i] = x;
        }
        */

        ~FurnitureClass() { }
    }
}