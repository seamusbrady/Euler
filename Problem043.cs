using System;
using System.Collections.Generic;
using System.Linq;
using Euler.Utility;

namespace Euler
{
    internal class Problem043
    {
        private long _sumDividiblePanDigitals;
        public long Run()
        {
            return FastSolution();
        }

        public long MySolution()
        {
            var pan = new PanDigital {TestFunction = Test};

            pan.GetPermutations("0123456789".ToCharArray());
            return _sumDividiblePanDigitals;
        }

        private bool Test(char[] pandigital)
        {
            const int len = 9;
            int[] divisors = { 1, 2, 3, 5, 7, 11, 13, 17 };
            var pandigitalNumber = ToNumber(pandigital);
            for (int i = len - 2; i > 0; i--)
            {
                int power = (int)Math.Pow(10, len - 3 - i + 1);

                var part = pandigitalNumber / power;
                var section = part % 1000;

                if (section % divisors[i] == 0) continue;
                return false;
            }
            _sumDividiblePanDigitals += pandigitalNumber;
            return true;
        }

        private static long ToNumber(char[] digits)
        {
            long number = 0;
            foreach (var d in digits)
            {
                number += ToInt(d);
                number *= 10;
            }
            number /= 10;
            return number;
        }

        static int ToInt(char d)
        {
            return d - '0';
        }

        public static long FastSolution()
        {
            int[] seq = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] primes = new int[] { 2, 3, 5, 7, 11, 13, 17 };

            int[] limits = new int[seq.Length];
            int count = 1;
            for (int index = limits.Length - 1; index >= 0; index--)
                limits[index] = count *= (seq.Length - index);
            count -= limits[1];   // to not generate combs with 0 as the first digit

            long sums = 0;
            for (int position = 0; position < count; position++)
            {
                List<int> numbers = seq.ToList();
                int[] permutation = new int[seq.Length];
                int index_permutation = 0;
                long number = 0;
                bool isDivisible = true;
                while (isDivisible && index_permutation + 1 < limits.Length)
                {
                    int index_numbers = (position % limits[index_permutation]) / limits[index_permutation + 1];
                    permutation[index_permutation++] = numbers[index_numbers];
                    numbers.RemoveAt(index_numbers);
                    //
                    if (index_permutation > 3)
                        if (!(isDivisible &= IsDivisible(permutation, index_permutation, primes)))
                            position += limits[index_permutation] - 1;   // to jump all the combs with the same digits found to not be divisible
                    number = number * 10 + permutation[index_permutation - 1];
                }
                if (isDivisible)
                {
                    permutation[index_permutation] = numbers[position % limits[index_permutation++]];
                    if (isDivisible &= IsDivisible(permutation, index_permutation, primes))
                        sums += number * 10 + permutation[index_permutation - 1];
                }
            }

            return sums;
        }

        private static bool IsDivisible(int[] permutation, int index_permutation, int[] primes)
        {
            int sum = 0;
            for (int index = 0; index < 3; index++)
                sum = sum * 10 + permutation[index_permutation - 3 + index];
            return sum % primes[index_permutation - 4] == 0;
        }
    }
}
