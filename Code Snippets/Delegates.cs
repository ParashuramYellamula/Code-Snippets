using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Snippets
{
	public class Delegates
	{
		public delegate int SumDelegate(int a, int b);

		public void CallDelegate()
		{
			Addition add = new Addition();
			SumDelegate sumDelegate = new SumDelegate(add.Sum);
			sumDelegate += add.Sub;
			sumDelegate(10, 20);
		}
	}

	public class Addition
	{
		public int Sum(int a, int b)
		{
			Console.WriteLine(a + b);
			return a + b;
		}
		public int Sub(int a, int b)
		{
			Console.WriteLine(a - b);
			return a - b;
		}
	}
}
