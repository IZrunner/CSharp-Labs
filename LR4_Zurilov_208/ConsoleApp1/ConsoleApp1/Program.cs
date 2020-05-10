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
            //Console.WriteLine("BGDN");

            //Завдання:
            //На базі класів із попередньої лабораторної роботи створіть додаток для демонстрації в коді наступних можливостей:
            //1.Навести приклад використання 3 статичних методів класу Array (+)
            //2.Використання ключових слів const та readonly (+)
            //3.Способів передачі параметрів у метод
            //    a.За значенням(value та reference) (+)
            //    b.Використання ключових слів ref та  out в тому числі і out в с#7. (+)
            //    c.Застосування ключового слова params (+)
            //    d.Передача іменованих аргументів. (+)
            //    e.Використання необов‘язкових аргументів (+)
            //    f.Створити метод, який може приймає два або більше параметрів (+)
            //4.Використання статичних змінних та методів
            //5.  * Додаткове завдання:
            //            a.Розібрати теоретично різницю між const та readonly.
            //            b.Класс містить два масиви: одновимірний та двовимірний.Реалізувати індексатор, який може працювати з одновимірним або двовимірним масивом в залежності від ситуації.
            //            c.Розібрати роботу статичних класів.


            FurnitureClass table = new FurnitureClass("table", 2, 3);
            FurnitureClass chair = null;
            int[] someArr = new int[3] { 1, 2, 3 };

            table.ReadThatCopiedArray(someArr);
            table.TransformCopy(5);
            Console.WriteLine($"For bad days, there are {FurnitureClass.reservedAmount} reserved things in the storage");
            Console.WriteLine($"A number of legs a standart furniture has is {table.GetLegs()}");
            FurnitureClass.FixTheSameObject(ref table);
            FurnitureClass.CreateBrandNewObject(out chair);
            Console.WriteLine($"{chair.ChangeTitle = "of Fire"}");
            chair.RandomEnumeration(56, 77,88,99,010);
            chair.UnkeptEnumeration(someOne: 12, someTwo: 34, someThree: 56);




























            Console.ReadKey();
        }
    }
}
