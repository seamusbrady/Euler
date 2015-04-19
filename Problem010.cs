using System;
using System.Collections;
using System.Numerics;

namespace Euler
{

    /// <summary>
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    /// Find the sum of all the primes below two million.
    /// </summary>
    class Problem010
    {
        public BigInteger Run()
        {
            const int limit = 2000000;

            BigInteger sum;
            
            //sum = Solution1(limit);
            //Console.WriteLine(sum);
            
            sum = SumPrimesUsingSieveOfSundaram(limit);
            return sum;
        }



        private static bool IsPrime(int n)
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


        private static BigInteger Solution1(int limit)
        {
            BigInteger sum = 5;
            int n = 5;

            while (n <= limit)
            {
                if (IsPrime(n))
                    sum = sum + n;
                n = n + 2;

                if (n <= limit && IsPrime(n))
                    sum = sum + n;
                n = n + 4;
            }

            return sum;
        }

        private static BigInteger SumPrimesUsingSieveOfSundaram(int topCandidate = 1000000)
        {
            int totalCount = 0;
            int k = topCandidate / 2;
            var myBa1 = new BitArray(k + 1);


            /* SEIVE */
            int maxVal = 0;
            int denominator = 0;
            for (int i = 1; i < k; i++)
            {
                denominator = (i << 1) + 1;
                maxVal = (k - i) / denominator;
                for (int j = i; j <= maxVal; j++)
                {
                    myBa1[i + j * denominator] = true;
                }
            }
            BigInteger sum = 2;
            for (int i = 1; i < k; i++)
            {
                if (!myBa1[i])
                {
                    totalCount++;
                    sum += (i << 1) + 1; // dummy contains prime number.The code is here not ignore the prime number calcuation part.
                }
            }

            return sum;
            //return (totalCount + 1); // 2 will be missed in Sieve Of Sundaram
        }
    }
}
