using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            //Завдання:
            //    На базі класів із попередньої лабораторної роботи створіть додаток для демонстрації в коді наступних можливостей:
            //    1.Використання абстрактного та запечатаного класів (+)
            //    2.Використання ключового слова this (+)
            //    3.Використання часткових класів (+)
            //    4.Не менше 3 конструкторів класу String (+)
            //    5.Не менше 5 методів класу String (+)
            //    6.Інтернування рядків (+)
            //    7.  * Додаткове завдання:
            //        a.Порівняння методів Equals класу Object.
            //        b.Пул рядків в IlDasm


            //Console.WriteLine("Hello World!");
            //string is an alias in C# for System.String
            //string constructors
            char[] nameCharAKAString = { 'I', 'v', 'a', 'n' };//1
            string nameString = new string(nameCharAKAString);//1
            char fillString = 'w'; int sizeOfString = 12;//2
            string cloneChar = new string(fillString, sizeOfString);//2
            string lastString = new string(nameCharAKAString, 1, 2);//3; nameCharAKAString - array of chars, 1 - start position of filling the new string, 
                                                                    //2 - number of elements to fill the new string 
            //string methods
            string sampleTextOne = "I'll be right back";           
            string sampleTextTwo = "No, you won't";
            sampleTextTwo = String.Copy(sampleTextOne);//1
            bool inspectString = sampleTextTwo.EndsWith(".");//2
            bool areEqualValues = String.Equals(cloneChar, sampleTextOne);//3
            int indexOfCharInName = nameString.IndexOf("I", 0, nameString.Length);//4
            //Console.WriteLine(indexOfCharInName);
            string newSentence = sampleTextOne.Insert(0, nameString + ", ");//5
            string brandNewSntence = String.Intern(sampleTextOne);//interning
            Console.WriteLine("Is brandNewSntence the same reference as sampleTextOne?: {0}", (Object)brandNewSntence == (Object)sampleTextOne);
            //Console.WriteLine(newSentence);


            DoChaoticAction act = new DoChaoticAction();
            act.ShowDirection(); act.ShowQuotation();
            Console.WriteLine("");

            DoRightAction act1 = new DoRightAction();
            act1.ShowDirection(); act1.ShowQuotation();
            Console.WriteLine("");

            DividedClassPRTOne act2 = new DividedClassPRTOne(12, 34);
            act2.GetValues();
            Console.WriteLine("");

            
            Console.WriteLine(nameString);
            Console.WriteLine("");

            Console.WriteLine(cloneChar);
            Console.WriteLine("");

            Console.WriteLine(lastString);
            Console.WriteLine("");



            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
