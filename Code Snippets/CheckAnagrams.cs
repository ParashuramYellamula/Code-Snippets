using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Snippets
{
	class CheckAnagrams
	{
		public void CheckTwoStringsAnagramsOrNot(string strInput1, string strInput2)
		{
			bool isAnagram = true;
			if (strInput1.Length != strInput2.Length)
				isAnagram = false;
			SortStringUsingSingleLoop sortStringUsingSingleLoop = new SortStringUsingSingleLoop();
			char [] chrInput1 = sortStringUsingSingleLoop.GetSortedString(strInput1);
			char [] chrInput2 = sortStringUsingSingleLoop.GetSortedString(strInput2);
			for(int i =0;i< chrInput1.Length -1;i++)
			{
				if (chrInput1[i] != chrInput2[i])
				{
					isAnagram = false;
				}
			}
			if (isAnagram)
				Console.WriteLine("Given Strings are Anagrams");
			else
				Console.WriteLine("Given Strings are not anagrams");
		}
	}
}
