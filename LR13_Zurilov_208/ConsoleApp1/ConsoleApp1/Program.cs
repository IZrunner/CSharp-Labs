using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		public delegate void OneParamSample(int someVal);
		public delegate void NoParamSample();
		

		public class SampleOne
		{
			private int localVal;
			public SampleOne()
			{
				this.localVal = 2;
			}

			public SampleOne(int some)
			{
				this.localVal = some;
			}

			public void DontReturnVal(int some)
			{
				Console.WriteLine($"This value is {some}");
			}

			public void CallFirstDelegate(OneParamSample funcParam, int some)
			{
				funcParam(some);
			}
			public void noParamFunc()
			{
				Console.WriteLine("No-parameters-function is called");
			}
		}




		static void Main(string[] args)
		{
			//Завдання: Cтворіть застосунок, який демонструю роботу делегатів:
			//	1.Делегат не повертає значення, та приймає один параметр.(+)
			//	2.Делегат не повертає значення, та не приймає параметрів.(+)
			//	3.Делегат не повертає значення, та приймає один параметр(використати вбудований варіант делегату).(+)
			//	4.Делегат не повертає значення, та не приймає параметрів(використати вбудований варіант делегату).(+)
			//	5.Навести приклади використання вбудованих делегатів у вбудованих класах.

						//1
			SampleOne firstObj = new SampleOne(5);		
			firstObj.DontReturnVal(5);
			firstObj.CallFirstDelegate(firstObj.DontReturnVal, 25);

						//2
			NoParamSample secondObj = firstObj.noParamFunc;
			secondObj();

						//3
			Action<int> actionDelegate = firstObj.DontReturnVal;
			actionDelegate(123);

						//4
			Action needMoreAction = firstObj.noParamFunc;
			needMoreAction();









		Console.ReadKey();
		}
	}
}
