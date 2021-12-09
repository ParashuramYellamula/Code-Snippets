using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Snippets
{
	class SortedArrays
	{
		public void FindLargestNumberLessThanGivenNumber(int[] arrInput, int intElement)
		{
			int intLargestElement = FindLargestNumber(arrInput, intElement);

			Console.WriteLine("Largest number less than " + intElement + " is " + intLargestElement);

		}

		private  int FindLargestNumber(int[] arrInput, int intElement)
		{
			if (intElement > arrInput[arrInput.Length - 1])
				return arrInput[arrInput.Length - 1];
			if (intElement < arrInput[0])
				return  -1;

			int mid = (arrInput.Length) / 2;

			if (intElement == arrInput[mid])
				return arrInput[mid - 1];
			else if (intElement > arrInput[mid])
			{
				for (int i = mid; i < arrInput.Length; i++)
				{
					if (intElement <= arrInput[i])
					{
						return  arrInput[i - 1];
					
					}
				}
			}
			else if (intElement < arrInput[mid])
			{
				for (int i = 0; i < mid; i++)
				{
					if (intElement <= arrInput[i])
					{
						return arrInput[i - 1];
					}
				}
			}
			return 0;
		}

		public void MergeTwoSortedArrays(int[] arr1, int[] arr2)
		{
			int l1 = arr1.Length;
			int l2 = arr2.Length;
			int[] result = new int[l1 + l2];
			int k = 0, i=0,j=0;

			while(i<l1 && j<l2)
			{
				if(arr1[i] <= arr2[j])
				{
					result[k] = arr1[i];
					k++;
					i++;
				}
				else
				{
					result[k] = arr2[j];
					k++;
					j++;
				}
			}
			for(int m=i;m<l1;m++)
			{
				result[k] = arr1[m];
				k++;
			}
			for (int m = j; m < l2; m++)
			{
				result[k] = arr2[m];
				k++;
			}

			Console.WriteLine("Merged Array: ");
			for (int m=0;m<result.Length;m++)
			{
				Console.Write(" " + result[m]);
			}

		}
	}
}
