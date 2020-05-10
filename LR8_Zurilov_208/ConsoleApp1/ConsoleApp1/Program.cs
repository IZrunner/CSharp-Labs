using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum WeekDays { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };   
    class Program
    {
        

        static void Main(string[] args)
        {
            int ExtendSomeValue(SomeA objToFix, int fixValue)
            {
                int returnValue = objToFix.firstVal + fixValue;
                return returnValue;

            }
            //Завдання:
            //1.Створити перерахування
            //    b.Непарні номери - дні неділі.Оголосити метод, який в якості параметру приймає день неділі  та виводить цей день на друк. (+)
            //2.Використовуючи один із класів свого варіанту створіть на його базі узагальнений клас та продемонструйте роботу з узагальненими класами та методами. (+)
            //3.Для одного із стандартних класів за Вашим вибором створіть метод розширення. Використовувати метод, який розглядався на лекції заборонено. (+)

            WeekDays someDaysToPrint = WeekDays.Monday;
            SomeA someObj = new SomeA();
            someObj.ShowDay(someDaysToPrint);
            //int someMathForObj = 123;
            //ExtendSomeValue(someObj, someMathForObj);
            int someMathForObj = ExtendSomeValue(someObj, 12);
            Console.WriteLine("Must be 22. Hmmmmm, let's see : " + someMathForObj);
            

            SomeAGeneric<string> firstbornChild = new SomeAGeneric<string> ("Firsts, ", "there was a word");
            firstbornChild.WhateverItDoes(firstbornChild, "And the word was ", "GOD");

            Console.ReadKey();

        }
    }
}
