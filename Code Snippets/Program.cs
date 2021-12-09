using System;
using System.Linq;
using System.Collections.Generic;

namespace Code_Snippets
{
	class Program
	{
		static void Main(string[] args)
		{
			ReverseString();
			Display();
			Console.ReadLine();
		}
		public static void Display()
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i % 3 == 0)
				{
					Console.WriteLine("fizz");
				}
				if (i % 5 == 0)
				{
					Console.WriteLine("buzz");
				}
				if (i % 3 == 0 && i % 5 == 0)
				{
					Console.WriteLine("fizzbuzz");
				}
			}
		}
		public static void ReverseString()
		{
			string strInput=Console.ReadLine();
			char[] input = strInput.ToCharArray();
			for(int i=strInput.Length;i>0;i--)
			{
				Console.Write(input[i-1]);
			}
		}
	}
}
