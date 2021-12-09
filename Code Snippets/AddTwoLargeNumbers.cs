using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Snippets
{
	class AddTwoLargeNumbers
	{
		public string AddLargeNumbers(string str1, string str2)
		{
            // Before proceeding further, make sure length
            // of str2 is larger.
            if (str1.Length > str2.Length)
            {
                string t = str1;
                str1 = str2;
                str2 = t;
            }

            // Take an empty string for storing result
            string str = "";

            // Calculate length of both string
            int n1 = str1.Length, n2 = str2.Length;
            int diff = n2 - n1;

            // Initially take carry zero
            int carry = 0;

            // Traverse from end of both strings
            for (int i = n1 - 1; i >= 0; i--)
            {
                // Do school mathematics, compute sum of
                // current digits and carry
                int sum = ((int)(str1[i] - '0') +
                        (int)(str2[i + diff] - '0') + carry);
                str += (char)(sum % 10 + '0');
                carry = sum / 10;
            }

            // Add remaining digits of str2[]
            for (int i = n2 - n1 - 1; i >= 0; i--)
            {
                int sum = ((int)(str2[i] - '0') + carry);
                str += (char)(sum % 10 + '0');
                carry = sum / 10;
            }

            // Add remaining carry
            if (carry > 0)
                str += (char)(carry + '0');

            // reverse resultant string
            char[] ch2 = str.ToCharArray();
            Array.Reverse(ch2);
            return new string(ch2);
        }
        public void AddLargeNumbersAndDisplay(string str1, string str2)
		{
            Console.WriteLine("Sum : " + AddLargeNumbers( str1,  str2));
		}
	}
}
