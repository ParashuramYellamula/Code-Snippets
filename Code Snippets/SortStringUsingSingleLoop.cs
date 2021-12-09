using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Snippets
{
	class SortStringUsingSingleLoop
	{
		public void SortString(string strInput)
		{
			Console.WriteLine("Sorting string Array with Single for loop : " + strInput);
			char[] chrInput = strInput.ToCharArray();

			for (int j = 0; j < chrInput.Length - 1; j++)
			{
				
				int chr1 = chrInput[j];
				int chr2 = chrInput[j + 1];
				if (chr1 > chr2)
				{
					char temp = chrInput[j];
					chrInput[j] = chrInput[j + 1];
					chrInput[j + 1] = temp;
					j = - 1;
				}
			}

			Console.WriteLine("Sorted Array: " + new string(chrInput));
		}

		public char[] GetSortedString(string strInput)
		{
			char[] chrInput = strInput.ToCharArray();

			for (int j = 0; j < chrInput.Length - 1; j++)
			{

				int chr1 = chrInput[j];
				int chr2 = chrInput[j + 1];
				if (chr1 > chr2)
				{
					char temp = chrInput[j];
					chrInput[j] = chrInput[j + 1];
					chrInput[j + 1] = temp;
					j = -1;
				}
			}

			return chrInput;
		}

	}
}
