using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{


		class Rethrow
		{
			public static void GenException()
			{
				//Array 'number' is bigger than 'denom'
				int[] number = { 4, 8, 16, 32, 64, 128, 256, 512 };
				int[] denom = { 2, 0, 4, 4, 0, 8 };
				for (int i = 0; i < number.Length; i++)
				{
					try
					{

						Console.WriteLine(number[i] + " / " +
							   denom[i] + " equals " + number[i] / denom[i]);
					}
					catch (DivideByZeroException)
					{
						Console.WriteLine("Zero division is forbidden!");
					}
					catch (IndexOutOfRangeException)
					{
						Console.WriteLine("Matching's not found.");
						throw; //Repeat exception generation 
					}
				}
			}
		}


		class CustomHandmadeException : Exception
		{			
			public CustomHandmadeException(string stupidMessage) : base(stupidMessage)
			{
				Console.WriteLine(stupidMessage);
			}
			public void Cure()
			{
				Console.WriteLine("Refactoring is near...");
			}
		}
		
					
		static void Main(string[] args)
		{
			//Завдання: Продемонструйте в коді:
			//1.Приклади виникнення та перехоплення exception (+)
			//2.Використання сatch без параметрів (+)
			//3.Повторну генерація exception  в блоці catch та спосіб розкрутки стеку(отримати 
			//початкову точку виникнення виключення після повторної генерації виключення) (+)
			//4.Створіть свій клас для генерації exception та використайте його в коді. (+)
			//5.Додатково: Наведіть в коді приклади генерації наступних виключень(використовувати throw 
			//заборонено, виключення повинно генеруватись CLR автоматично):
			//	5.1.NullReferenceException ()
			//	5.2.ArgumentNullException ()
			//	5.3.InvalidOperationException ()


			int x_1 = 1, y_1 = 0, z_1;//1-st task
			int x_2 = 1, y_2 = 0, z_2;//2-nd task
					//1
			try
			{
				z_1 = x_1 / y_1;
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine("Zero division, result = 0");
				z_1 = 0;
			}
			Console.WriteLine("z = " + z_1);


					//2
			try
			{
				z_2 = x_2 / y_2;
			}
			catch (Exception)
			{
				Console.WriteLine("Zero division, result = 0");
			}
			catch
			{
				Console.WriteLine("Alone old catch block");
			}


					//3
			try
			{
				Rethrow.GenException();
			}
			catch (IndexOutOfRangeException)
			{
				// перехватить исключение повторно
				Console.WriteLine("Fatal error - programm is interrupted.");
			}


			//4
			try
			{
				throw new CustomHandmadeException("Hello World");
			}
			catch(CustomHandmadeException expectedExc)
			{
				Console.WriteLine("What did you expect?");
				expectedExc.Cure();
			}





			Console.ReadKey();			
		}
	}
}
