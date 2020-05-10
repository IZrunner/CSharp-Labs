using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {           
            //Завдання:
            //    Використовуючи класи із свого варіанту, створіть додаток для демонстрації в коді наслідування та поліморфізму:
            //    1.Створити метод, який в якості параметра приймає тип Object. При виклику методу передавати в якості параметра 
            //        об‘єкти свого класу(в методі використати as). (+-)
            //    2.Створити метод, який в якості параметра приймає тип Вашого базового класу. При виклику методу передавати в якості 
            //        параметра об‘єкти своїх класів.Розібратись в різниці виконання цього методу і методу із пункту 1. (+)
            //    3.Створити масив об‘єктів базового та похідних класів для демонстрації поліморфізму. (+)
            //    4.Продемонструвати роботу new. (+)
            //    5.Додатково: ()
            //        a.Розібрати теоретично необхідність використання new.

            // Classes : 9.транспортний засіб, потяг, автомобіль;
            
            int HPForVechs = 45; int capacityForVechs = 4;
            int HPForAutos = 80; int capacityForAutos = 4; int doorsForAutos = 3;            
           
            Vehicle lada = new Vehicle();
            Vehicle.TetsMethodVehicle(lada);

            Auto kamaz = new Auto();
            Train lightning = new Train();
            Vehicle[] someCorporation = new Vehicle[5];
            Auto[] someAutoBrand = new Auto[5];           
            kamaz.TetsMethodAuto(lada);

            Console.WriteLine("In the base class : "); lada.ShowKilledVar();
            Console.WriteLine("In the first derived class : "); kamaz.ShowKilledVar();
            Console.WriteLine("In the second derived class : "); lightning.ShowKilledVar();

            Console.WriteLine("\n\t\t\t--------------------- Show array of Vehicles ---------------------\n");
            for (int i = 0; i < 5; i++)
            {
                string titleForVechs = "new vehicle";
                titleForVechs = titleForVechs + i.ToString();
                HPForVechs += i + 10;
                someCorporation[i] = new Vehicle(titleForVechs, HPForVechs, capacityForVechs);
                someCorporation[i].ShowWholeData();
            }

            Console.WriteLine("\n\t\t\t--------------------- Show array of Autos ---------------------\n");
            for (int i = 0; i < 5; i++)
            {
                string titleForAutos = "new car";
                titleForAutos = titleForAutos + i.ToString();
                HPForAutos += i + 10;
                doorsForAutos = i;
                someAutoBrand[i] = new Auto(titleForAutos, HPForAutos, capacityForAutos, doorsForAutos);
                someAutoBrand[i].ShowWholeData();
            }

            Console.ReadKey();
        }
    }
}
