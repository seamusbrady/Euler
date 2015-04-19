using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Euler
{
    class Problem206
    {
        public double Run()
        {
            foreach (var num in Squares())
            {
                if (Regex.IsMatch(num.ToString(), "1.2.3.4.5.6.7.8.9.0"))
                    return Math.Exp(BigInteger.Log(num) / 2);
            }
            throw new Exception("Not found");
        }

        private static IEnumerable<BigInteger> Squares()
        {
            // Return squares 1 at a time from biggest to smallest
            const int maxSquareRoot = 1389026624;
            const int minSquareRoot = 439248785;

            for (int i = maxSquareRoot; i > minSquareRoot; i--)
                yield return BigInteger.Pow(i, 2);
        }
    }
}
