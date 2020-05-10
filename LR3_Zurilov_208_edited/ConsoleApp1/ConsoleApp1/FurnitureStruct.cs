using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct FurnitureStruct
    {
        private string title;
        private int amount;
        private double price;

        private static int reservedAmount;
        static FurnitureStruct()
        {
            reservedAmount = 123;
            Console.WriteLine($"Once called, reserved amount is {reservedAmount}\n");
        }

        public FurnitureStruct(string Title, int Amount, double Price)
        {
            title = Title;
            amount = Amount;
            price = Price;
        }

        public FurnitureStruct(FurnitureStruct exmpl_1)
        {
            title = exmpl_1.title;
            amount = exmpl_1.amount;
            price = exmpl_1.price;
        }

        public override string ToString()
        {
            return base.ToString() + " is the basic class name";
        }
        
        public void Echo()
        {
            Console.WriteLine($"Title : {title}\nAmount : {amount}\nPrice : {price}");
        }    
    }
}