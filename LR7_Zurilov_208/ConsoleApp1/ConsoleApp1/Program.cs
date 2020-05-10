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
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");


            //Завдання: Перевантажте в класі свого варіанту:
            //    1.Наступні операції:               
            //        1.2.Студенти з непарними номерами в журналі:
            //        1.2.1.операцію віднімання одного об‘єкта свого класу від іншого; (+)
            //        1.2.2.операцію декримента для об‘єкта свого класу; (+)
            //        1.2.3.операцію додавання числа до об‘єкту класа; (+)
            //        1.2.4.визначте метод неявного перетворення типу дійсного числа в об‘єкт класу; (+)
            //        1.2.5.визначте метод явного перетворення об‘єкта класа в дійсне число. ()

            //        Варіанти з переліком класів:
            //        9.автомобіль;

            Vehicle autoOne = new Vehicle(120, 4);
            Vehicle autoTwo = new Vehicle(70, 4);
            Vehicle autoSubtr = new Vehicle();
            Vehicle convValToAuto = 123;
            

            Console.WriteLine("Input a value to add to an object : ");
            int someVal = Convert.ToInt32(Console.ReadLine());           

            autoSubtr = autoOne - autoTwo;
            Console.WriteLine(autoSubtr.horsePower);
            autoOne--;
            Console.WriteLine(autoOne.horsePower);
            autoOne = autoOne + someVal;
            Console.WriteLine(autoOne.capacity);
            Console.WriteLine(convValToAuto.horsePower);
            Int32 sampleInt = (Int32)convValToAuto;
            Console.WriteLine(sampleInt);
















            Console.ReadKey();            
        }
    }
}
