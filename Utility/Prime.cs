using System;
using System.Collections;
using System.Collections.Generic;

namespace Euler.Utility
{
    static class Prime
    {
        public static HashSet<int> GetPrimesUsingSieveOfSundaram(int topCandidate = 1000000)
        {
            int k = topCandidate / 2;
            var myBa1 = new BitArray(k + 1);

            var primes = new HashSet<int> { 2 };

            /* SEIVE */
            for (int i = 1; i < k; i++)
            {
                int denominator = (i << 1) + 1;
                int maxVal = (k - i) / denominator;
                for (int j = i; j <= maxVal; j++)
                {
                    myBa1[i + j * denominator] = true;
                }
            }
            for (int i = 1; i < k; i++)
            {
                if (!myBa1[i])
                {
                    primes.Add((i << 1) + 1);
                }
            }

            return primes;
        }

        public static bool IsPrime(int n)   
        {
            if (n == 1) return false;
            if (n < 4) return true;
            if (n % 2 == 0) return false;
            if (n < 9) return true;
            if (n % 3 == 0) return false;

            var r = Math.Floor(Math.Sqrt(n));
            var f = 5;
            do
            {
                if (n % f == 0) return false;
                if (n % (f + 2) == 0) return false;
                f = f + 6;
            } while (f <= r);

            return true;
        }

    }
}
