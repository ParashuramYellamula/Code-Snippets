using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Snippets
{
	class KnapsackProblemSolution
	{
		public void KnapsackReccursiveSolution()
		{
			int[] val = new int[] { 60, 100, 120 };
			int[] wt = new int[] { 10, 20, 30 };
			int w = 50;
			int n = val.Length ;

			Console.WriteLine(KnapsackR( wt, val, w, n));
		}
		public int Max(int a, int b)
		{
			return (a > b) ? a : b;
		}

		public int KnapsackR(int[] arrWeights, int[] arrProfits, int w, int n)
		{
			if (w == 0 || n == 0)
				return 0;
			if (arrWeights[n - 1] > w)
				return KnapsackR(arrWeights, arrProfits, w, n - 1);
			else
				return Max(KnapsackR(arrWeights, arrProfits, w, n - 1), arrProfits[n - 1]) + KnapsackR(arrWeights, arrProfits, w - arrWeights[n - 1], n - 1);
		}
	}
}
