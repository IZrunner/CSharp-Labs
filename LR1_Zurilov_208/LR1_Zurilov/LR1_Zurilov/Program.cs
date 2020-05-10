using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
    Завдання:
    Створіть додаток для демонстрації в коді наступних можливостей:
    1.	Оголошення змінних різних типів та різницю в роботі оператора присвоєння для цих типів. (+-)
    2.	Роботи із простими типами даних, як із об‘єктами структури (роботу із методами). (+)
    3.	Явне та неявне перетворення типів. (+)
    4.	Використання ключових слів checked / unchecked (+)
    5.	Нульові типи. (+)
    6.	Використання операторів циклу, умовних операторів та оператора switch. (+)
    7.	Додатково для поглибленого вивчення:
        a.	Перегляд коду MSIL(Передивитись відеоурок)
        b.	Огляд можливостей класу Environment

*/


namespace LR1_Zurilov
{
    class Program
    {
        class Sample // for testing null operator
        {
            public void ShowMessage()
            {
                Console.WriteLine("Something written here and there");
            }
        }


        static int Main()
        {
            //Console.WriteLine("I've printed my first EPIC STRING!!!);
            //Console.WriteLine("is it on the second field?);

            int basicInt = 4;
            float basicFloatOne = 4f;
            float basicFloatTwo = 8f;
            bool basicBoolean = true;
            string basicName = "Ivan";
            char basicChar = 'x';
            double basicDouble = 1.23;
            string[] lastName = {"Z", "u", "r", "i", "l", "o", "v" };


            float basicFloatSum = basicFloatOne + basicFloatTwo;
            double convertedFloatSum = basicFloatSum; // Implicit conversion (неявне перетворення); float to double
            Console.WriteLine(convertedFloatSum);

            int convertedIntSum = (int)basicDouble;
            Console.WriteLine(convertedIntSum); // Explicit conversion (явне перетворення); double to int

            //Console.WriteLine(checked(2147483647 + basicInt)); // overfow check + exception message
            Console.WriteLine(unchecked(2147483647 + basicInt)); // no message + no checking

            // NULL means representing an empty (null) reference
            Sample obj1; // create object
            obj1 = null; // set NULL type, not able to call the method, bc object doesn't refer to class
            obj1 = new Sample(); // set object as an object of our class
            obj1.ShowMessage(); // OK

            for(int i = 0; i < lastName.Length; i++)
            {
                Console.Write(lastName[i]);
            }

            Console.WriteLine(" ");

            while(basicInt > 0)
            {
                Console.WriteLine("(while) Reverse iteration {0}", basicInt);
                basicInt--;
            }

            do
            {
                basicInt--;
                Console.WriteLine("(do, while) Reverse iteration {0}", basicInt);
                basicFloatOne--;
            } while (basicFloatOne > 0);

            if(basicBoolean)
            {
                Console.WriteLine("The condition is true");
            }
            else
            {
                Console.WriteLine("The condition is false");
            }

            // Indian style
            Console.WriteLine("Iput integer from 0 to 3");
            string markerTMP = Console.ReadLine();
            int marker = int.Parse(markerTMP);
            switch (marker)
            {
                case 0:
                Console.Write(basicName[0]);
                break;

                case 1:
                Console.Write(basicName[1]);
                break;

                case 2:
                Console.Write(basicName[2]);
                break;

                case 3:
                Console.Write(basicName[3]);
                break;

                default: // Indian style starts here
                if(marker > 3 && marker < 100)
                {
                   for(int i = 0; i < basicName.Length; i++)
                   {
                   Console.Write(basicName[i]);
                   }
                }
                else
                {
                Console.WriteLine("Put off your cat from the keyboard, please");
                }
                break;
            }

            Console.WriteLine(" ");


            //Numeric strings sandbox
            /*
            Console.WriteLine("Print some 2 integers ( {0} and {1} ) from a set of 2 integers", 2, 3);
            Console.WriteLine("Now print a few more integers ( {0}, {1}, {1}, {0} ), from the same set", 2, 3);
            Console.WriteLine($"Now print some integer declared before ( {basicInt} )"); // $ before " "
            */

            Console.ReadKey();
            return 0;
        }
    }
}