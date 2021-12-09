using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Snippets
{
	class CallMethodsWithInputs
	{
		public void CreateInstanceAndCallMethods()
		{

			KnapsackProblemSolution knapsackProblemSolution = new KnapsackProblemSolution();
			knapsackProblemSolution.KnapsackReccursiveSolution();

			AddTwoLargeNumbers addTwoLargeNumbers = new AddTwoLargeNumbers();
			addTwoLargeNumbers.AddLargeNumbersAndDisplay("996859", "141");

			SortedArrays sortedArrays = new SortedArrays();
			int[] arrInput = { 11,22,33,84,96};
			int[] arrInput2 = { 10, 12, 34, 84, 96,97,98 };
			sortedArrays.MergeTwoSortedArrays(arrInput, arrInput2);
			sortedArrays.FindLargestNumberLessThanGivenNumber(arrInput, 35);

			CheckAnagrams checkAnagrams = new CheckAnagrams();
			checkAnagrams.CheckTwoStringsAnagramsOrNot("SILENT","LISTEA");

			SortStringUsingSingleLoop sortStringUsingSingleLoop = new SortStringUsingSingleLoop();
			sortStringUsingSingleLoop.SortString("microsoft");
		}
	}
}
