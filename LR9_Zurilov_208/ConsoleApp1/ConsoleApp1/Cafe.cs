using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cafe : IPlaceOfRest, IComparable<Cafe>, IComparer<Cafe>
    {
        public string coordinates;
        public int maxCrowdCapacity;
        public float largestExpenses;

        public Cafe()
        {
            this.coordinates = "your kitchen"; this.maxCrowdCapacity = 12; this.largestExpenses = 3000f;
        }

        public Cafe(string varSomeBasement, int varCrowdCapacity, float varLargestExpenses)
        {
            this.coordinates = varSomeBasement; this.maxCrowdCapacity = varCrowdCapacity; this.largestExpenses = varLargestExpenses;
        }

        public string SetCoordinates { get => coordinates; set => coordinates = value; }
        public int SetMaxCrowd { get => maxCrowdCapacity; set => maxCrowdCapacity = value; }

        public int Compare(Cafe x, Cafe y)
        {
            return x.largestExpenses.CompareTo(y.largestExpenses);
        }

        public int CompareTo(object any)
        {
            Cafe newSome = (Cafe)any;
            return coordinates.CompareTo(newSome.coordinates);
        }

        //public int CompareTo(object obj)
        //{
        //    Cafe any = (Cafe)obj;
        //    return maxCrowdCapacity - any.maxCrowdCapacity;
        //}

        public int CompareTo(Cafe any)
        {
            return maxCrowdCapacity.CompareTo(any.maxCrowdCapacity);
        }

        public float ComputeExpenses()
        {
            Console.WriteLine("Choose your currency : 1 - USA Dollar, 2 - Euro, 3 - UA Grivna");
            int currencyChoice = int.Parse(Console.ReadLine());
            Console.WriteLine("How much have you spent?");
            float amountOfSpentMoney = float.Parse(Console.ReadLine());
            switch (currencyChoice)
            {
                case 1:
                    largestExpenses = amountOfSpentMoney * 3.69f;
                    Console.WriteLine("You spent " + largestExpenses + " Shekels");
                    return largestExpenses;
                    break;

                case 2:
                    largestExpenses = amountOfSpentMoney * 4.15f;
                    Console.WriteLine("You spent " + largestExpenses + " Shekels");
                    return largestExpenses;
                    break;

                case 3:
                    largestExpenses = amountOfSpentMoney * 0.13f;
                    Console.WriteLine("You spent " + largestExpenses + " Shekels");
                    return largestExpenses;
                    break;

                default :
                    Console.WriteLine("IT'S OVER 9000!!!");
                    return largestExpenses = 9001;
                    break;
            }
        }

        public void ShowAds()
        {
            Console.WriteLine("PLAY HARD * EAT WELL * DRINK LOCAL");
        }
    }
}