using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{

		class SomeDestruction : IDisposable
		{
			public int someVal;
			public SomeDestruction(int argVal)
			{
				this.someVal = argVal;
			}

			public void PrintSomething()
			{
				Console.WriteLine("Sent value is " + someVal);
			}

			public void Dispose()
			{
				Console.WriteLine("Disposable fix");
			}
		}

		class AnotherDestruction
		{
			public void PrintMessage()
			{
				Console.WriteLine("We're all mortal");
			}		

			~AnotherDestruction()
			{
				Console.WriteLine("You'll never see me");
			}
		}
		static void Main(string[] args)
		{
			//Завдання: Продемонструйте в коді:
			//1.Використання методу Dispose та інтерфейсу IDisposable. (+)
			//2.Використання методу Finalize. (+)
			//3.Використання ключового слова using при фіналізації об‘єктів(для демонстрації 
			//обрати один із бібліотечних класів, який реалізує вказаний інтерфейс). (+)
			//4.Роботу з трьома  методами GC. (+)
			//5.Додатково: 
			//	a.реалізація паттерну Dispose. ()
			AnotherDestruction secondRider = new AnotherDestruction();//2
			SomeDestruction firstRider = new SomeDestruction(1);//1
			firstRider.PrintSomething();
			Console.WriteLine("Currentn generation of the firstRider-object is " + GC.GetGeneration(firstRider));
			firstRider.Dispose();

			using (SomeDestruction secondOne = new SomeDestruction(2))
			{
				secondOne.PrintSomething();				
			}
			GC.Collect(0);
			Console.WriteLine("The number of bytes currently allocated in managed memory " + GC.GetTotalMemory(false));
























			Console.ReadKey();
		}
	}
}
