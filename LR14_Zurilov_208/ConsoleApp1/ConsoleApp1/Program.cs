using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApp1
{	
	class Program
	{
		[System.Serializable]
		public class classToBeSerialized
		{
			public int someVal;
			public string someStr;
			public classToBeSerialized(int someParamVal, string quotationParam)
			{
				this.someVal = someParamVal;
				this.someStr = quotationParam;
			}
			public classToBeSerialized() { }
		}
		static void Main(string[] args)
		{
			//Завдання: Cтворіть застосунок, який демонструє використання серіалізації:
			//	1.Всім студентам чоловічої статі продемонструвати серіалізацію в форматі XML.()
			
			classToBeSerialized someObjToBeSerialized = new classToBeSerialized(2, "But the magic that we'll feel is worth the lifetime");
			XmlSerializer formatManipulator = new XmlSerializer(typeof(classToBeSerialized));
			using (FileStream fs = new FileStream("quotation.xml", FileMode.OpenOrCreate))
			{
				formatManipulator.Serialize(fs, someObjToBeSerialized);
				Console.WriteLine("Object has been serialized succesfully");
			}
			using (FileStream fs = new FileStream("quotation.xml", FileMode.OpenOrCreate))
			{
				classToBeSerialized brandNewObj = (classToBeSerialized)formatManipulator.Deserialize(fs);
				Console.WriteLine("Object has been deserialized succesfully");
				Console.WriteLine($"Some value is {brandNewObj.someVal}, the quotation is {brandNewObj.someStr}");
			}




				Console.ReadKey();			
		}
	}
}
