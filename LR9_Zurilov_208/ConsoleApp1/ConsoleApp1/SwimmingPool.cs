using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SwimmingPool : IPlaceOfRest
    {
        public string coordinates;
        public int maxCrowdCapacity;
        public float largestExpenses;

        public SwimmingPool()
        {
            this.coordinates = "your bathroom"; this.maxCrowdCapacity = 5; this.largestExpenses = 7500f;
        }

        public SwimmingPool(string varSomeBasement, int varSrowdCapacity, float varLargestExpenses)
        {
            this.coordinates = varSomeBasement; this.maxCrowdCapacity = varSrowdCapacity; this.largestExpenses = varLargestExpenses;
        }

        public string SetCoordinates { get => coordinates; set => coordinates = value; }
        public int SetMaxCrowd { get => maxCrowdCapacity; set => maxCrowdCapacity = value; }

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

                default:
                    Console.WriteLine("IT'S OVER 9000!!!");
                    return largestExpenses = 9001;
                    break;
            }
        }

        public void ShowAds()
        {
            Console.WriteLine("IT'S COOL AT THE POOL");
        }
    }
}
