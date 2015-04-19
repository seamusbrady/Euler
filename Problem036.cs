using System;
using System.Linq;

namespace Euler
{
    class Problem036
    {
        public int Run()
        {
            return RunTest();

        }

        public int RunTest()
        {
            var sum = 0;
            for (int i = 1; i < 1000000; i++)
            {
                if (IsPalindrome(i.ToString()) && IsPalindromeBase2(i))
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }

            return sum;
        }

        public bool IsPalindromeBase2(int num)
        {
            string binary = Convert.ToString(num, 2);
            return IsPalindrome(binary);
        }

        public bool IsPalindrome(string num)
        {
            return num.SequenceEqual(num.Reverse());
        }


//Also, for numbers under 1000000, palindromes are of one of these forms:

//a
//aa
//aba
//abba
//abcba
//abccba

//A can be either 1, 3, 5, 7, or 9, while b and c can 0, 1, 2...8, 9.  So the amount of numbers in each form are:

//a      - 5
//aa     - 5
//aba    - 50
//abba   - 50
//abcba  - 500
//abccba - 500

//This adds up to a total of 1110 possibilities for base 10 palindromes, instead of 999999.
    }
}
