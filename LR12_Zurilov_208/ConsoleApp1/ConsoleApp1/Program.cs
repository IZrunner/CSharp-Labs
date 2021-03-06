using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		//ARRAY LIST
		//class Steamer : IComparable, IComparer
		//{
		//	string name;
		//	int power;
		//	float price;

		//	public Steamer() { }
		//	public Steamer(string name, int power, float price)
		//	{
		//		this.name = name;
		//		this.power = power;
		//		this.price = price;
		//	}

		//	public float Price { get => price; set => price = value; }

		//	public int Compare(object x, object y)
		//	{
		//		Steamer s1 = (Steamer)x;
		//		Steamer s2 = (Steamer)y;
		//		return s1.power.CompareTo(s2.power);
		//	}

		//	public int CompareTo(object obj)
		//	{
		//		Steamer steam = (Steamer)obj;
		//		return name.CompareTo(steam.name);
		//	}

		//	public override string ToString()
		//	{
		//		return name + " " + power + " " + price;
		//	}
		//}
		//class PriceSort : IComparer
		//{
		//	public int Compare(object x, object y)
		//	{
		//		Steamer s1 = (Steamer)x;
		//		Steamer s2 = (Steamer)y;
		//		return s1.Price.CompareTo(s2.Price);
		//	}
		//}
		//static void Main(string[] args)
		//{
		//	ArrayList listOfSteamers = new ArrayList();
		//	listOfSteamers.Add(new Steamer("Avrora", 400, 680f));
		//	listOfSteamers.Add(new Steamer("Titanic", 840, 9000f));
		//	listOfSteamers.Add(new Steamer("Cargo", 1200, 2600f));

		//	listOfSteamers.Sort();

		//	Console.WriteLine(listOfSteamers.Count + " " + listOfSteamers.Capacity);

		//	foreach (Steamer steamer in listOfSteamers)
		//	{
		//		Console.WriteLine(steamer);
		//	}

		//	listOfSteamers.RemoveAt(1);
		//	listOfSteamers.RemoveRange(0, 1);
		//	listOfSteamers.Clear();

		//	listOfSteamers.Add(new Steamer("Avrora", 400, 680f));
		//	listOfSteamers.Add(new Steamer("Titanic", 840, 9000f));
		//	listOfSteamers.Add(new Steamer("Cargo", 1200, 2600f));

		//	Steamer[] steamArr = (Steamer[])listOfSteamers.ToArray(typeof(Steamer));
		//	Console.WriteLine(steamArr[0].ToString());
		//	Console.ReadLine();
		//}


		//LIST
		//class Steamer : IComparable, IComparer
		//{
		//	string name;
		//	int power;
		//	float price;

		//	public Steamer() { }
		//	public Steamer(string name, int power, float price)
		//	{
		//		this.name = name;
		//		this.power = power;
		//		this.price = price;
		//	}

		//	public float Price { get => price; set => price = value; }

		//	public int Compare(object x, object y)
		//	{
		//		Steamer s1 = (Steamer)x;
		//		Steamer s2 = (Steamer)y;
		//		return s1.power.CompareTo(s2.power);
		//	}

		//	public int CompareTo(object obj)
		//	{
		//		Steamer steam = (Steamer)obj;
		//		return name.CompareTo(steam.name);
		//	}

		//	public override string ToString()
		//	{
		//		return name + " " + power + " " + price;
		//	}
		//}
		//class PriceSort : IComparer
		//{
		//	public int Compare(object x, object y)
		//	{
		//		Steamer s1 = (Steamer)x;
		//		Steamer s2 = (Steamer)y;
		//		return s1.Price.CompareTo(s2.Price);
		//	}
		//}

		//class GenericClass<T> where T : Steamer, new()
		//{
		//	T p;
		//	public T P { get => p; set => p = value; }
		//	public GenericClass()
		//	{
		//		p = null;
		//		p = new T();
		//	}
		//}


		//static void Main(string[] args)
		//{
		//	List<Steamer> listOfSteamers = new List<Steamer>();
		//	listOfSteamers.Add(new Steamer("Avrora", 400, 680f));
		//	listOfSteamers.Add(new Steamer("Titanic", 840, 9000f));
		//	listOfSteamers.Add(new Steamer("Cargo", 1200, 2600f));

		//	listOfSteamers.Sort();

		//	listOfSteamers.Insert(2, new Steamer("Gargo", 800, 1600f));

		//	Console.WriteLine(listOfSteamers.Count + " " + listOfSteamers.Capacity);

		//	foreach (Steamer steamer in listOfSteamers)
		//	{
		//		Console.WriteLine(steamer);
		//	}

		//	listOfSteamers.RemoveAt(1);
		//	listOfSteamers.RemoveRange(0, 1);
		//	listOfSteamers.Clear();

		//	listOfSteamers.Add(new Steamer("Avrora", 400, 680f));
		//	listOfSteamers.Add(new Steamer("Titanic", 840, 9000f));
		//	listOfSteamers.Add(new Steamer("Cargo", 1200, 2600f));
		//	foreach (Steamer steamer in listOfSteamers)
		//	{
		//		Console.WriteLine(steamer);
		//	}
		//	Console.ReadLine();
		//}


					//HASH-SET
		class Steamer
		{
			string name;
			int power;
			float price;

			public Steamer() { }
			public Steamer(string name, int power, float price)
			{
				this.name = name;
				this.power = power;
				this.price = price;
			}

			public override bool Equals(object obj)
			{
				if (!(obj is Steamer))
					return false;
				Steamer s = (Steamer)obj;
				return name == s.name && power == s.power && price == s.price;
			}
			public override int GetHashCode()
			{
				return Tuple.Create(power, price).GetHashCode();
			}

			public override string ToString()
			{
				return name + " " + power + " " + price;
			}
		}

		static void Main(string[] args)
		{
			HashSet<Steamer> h = new HashSet<Steamer>();
			h.Add(new Steamer("Avrora", 400, 680f));
			h.Add(new Steamer("Titanic", 840, 9000f));
			h.Add(new Steamer("Cargo", 1200, 2600f));
			h.Add(new Steamer("Cargo", 1200, 2600f));
			foreach (Steamer hValue in h)
			{
				Console.WriteLine(hValue);
			}
			Console.ReadLine();
		}

	}
}
