using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void ShowInAShow(IPlaceOfRest bufferObj)
        {
            bufferObj.ShowAds();
        }

        static void Main(string[] args)
        {
            //Завдання:
            //    1.Використовуючи класи із свого варіанту (9.	місце відпочинку, кафе, басейн), 
            //    створіть додаток для демонстрації в коді використання інтерфейсів та поліморфізму з використанням інтерфейсів:   
            //        a.Один із варіантів класу використайте в якості інтерфейсу.  (+)
            //        b.Два інших класи повинні реалізовувати оголошений інтерфейс. (+)
            //        c.Кпас Program повинен містити метод, який в якості параметра приймає інтерфейс.  
            //        При виклику методу передавати в якості параметра об‘єкти своїх класів. (+)
            //        d.Створіть масив об‘єктів одного із класів свого варіанту.  Забезпечте можливість сортування 
            //        масиву по кожному із трьох полів класу. Необхідно використати хоча б один раз узагальнену та 
            //		  неузагальнену форму інтерфейсів. (+)
            //    2.Додатково: Використовуючи класи свого варіанту(2.	Летовище, літаки (тип літака, потужність 
            //    двигуна, кількість пасажирів)), виконайте наступні завдання:   
            //        a.Оголосіть класи таким чином, щоб один із класів, підходящий за змістом, містив масив об‘єктів іншого класу. ()
            //        b.Організуйте використання циклу foreach для перегляду об‘єктів масиву(використання інтерфейсів  IEnumarable та IEnumerator). ()

            Cafe parisInOktb = new Cafe();
            Cafe[] cavesOfNiko = { new Cafe("kitchen", 6, 100f), new Cafe("1-st room", 10, 200f), new Cafe("2-nd room", 5, 75f) };
            ShowInAShow(parisInOktb);


            //Array.Sort(cavesOfNiko);
            //foreach (Cafe obj in cavesOfNiko)
            //    Console.WriteLine(obj.maxCrowdCapacity);
            //Console.WriteLine();

            Array.Sort(cavesOfNiko);
            foreach (Cafe obj in cavesOfNiko)
                Console.WriteLine(obj.maxCrowdCapacity);
            Console.WriteLine();

            Array.Sort(cavesOfNiko);
            foreach (Cafe obj in cavesOfNiko)
                Console.WriteLine(obj.largestExpenses);
            Console.WriteLine();

            Array.Sort(cavesOfNiko);
            foreach (Cafe obj in cavesOfNiko)
                Console.WriteLine(obj.coordinates);
            Console.WriteLine();




            Console.ReadKey();           
        }
    }
}
