using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /* IMPOSSIBLE TO DERIVE A STRUCT
    public struct SomeStruct
    {
        public void SomeOut()
        {
            Console.WriteLine("some");
        }
    }

    public struct TryToDerive : SomeStruct
    {

    }
    */


    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello world");

            /*
            Завдання:
                1.	Створіть застосунок та оголосіть  в ньому  структуру відповідно до свого варіанту. 
                Виконай наступні дії із структурою:
                    a.	Оголосіть всі можливі конструктори. (+)
                    b.	Продемонструйте роботу із всіма можливими конструкторами структури. (+)
                    c.	Покажіть в коді неможливість використання структури в якості базової. (?)
                    d.	Покажіть в коді неможливість наслідування структурою іншої структури або класу. (+)
                    e.	Продемонструйте роботу методу Equals та поясніть отриманий результат. (+)
                    f.	Продемонструйте роботу методу ToString. Модифікуйте цей метод. (+)
                2.	Створіть застосунок та оголосіть  в ньому  клас відповідно до свого варіанту. Клас повинен містити:
                    a.	Властивості. (+)
                    b.	Автоматичні властивості. (+)
                    c.	Індексатор. ()
                    d.	Властивість для статичного поля. (+)
                3.	Додатково для поглибленого вивчення: переглянути, як виглядають властивості та 
                індексатори в коді MSIL. Продемонструвати код  MSIL при захисті лабораторної роботи. ()

                Варіанти структур та класів:
                Варіант 9:
                    Об'єкти – меблі ( шафи, ліжка, дивани, столи) у магазині. Поля (атрибути):
                        •	Назва
                        •	Кількість
                        •	Ціна
            */
            

            FurnitureStruct table = new FurnitureStruct("Desk", 5, 200);
            FurnitureStruct sofa = new FurnitureStruct(table);

            table.Echo();
            Console.WriteLine("");
            sofa.Echo();
            Console.WriteLine("Are these objects equal ? : {0}", Object.Equals(table, sofa));
            Console.WriteLine("Execute ToString method with some created object : {0}", table.ToString());

            FurnitureClass chair = new FurnitureClass("chair", 5, 250);
            Console.WriteLine("The price in dollars for chair is {0}", chair.PriceInDollars);
            chair.ChangeTitle = "GamingChair";
            Console.WriteLine("Changed title for chair is {0}", chair.ChangeTitle);
            Console.WriteLine("I changed something {0}", FurnitureClass.ChangeSmth = "IDK");
            //write to x, if %2 == 0, else - to y
            //chair[4] = 25;
            //Console.WriteLine(chair[4]);

            
















            Console.ReadKey();
        }
    }
}
