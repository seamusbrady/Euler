using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem012
    {
        public int Run()
        {
            int triangle = 1;
            int i = 1;

            var primes = GetPrimesUsingSieveOfSundaram(40);
            Console.WriteLine(string.Join(", ", primes));

            var result = GetDivisors(primes);
            return result;
            return FindTriangularIndex(500);


            IEnumerable<int> divisors = new List<int>();
            int mostFactors = 0;
            do
            {
                i++;
                triangle += i;
                divisors = GetDivisors(triangle);
                if (divisors.Count() > mostFactors)
                {
                    mostFactors = divisors.Count();
                    Console.WriteLine("{0}: {1}", triangle, mostFactors);
                }
                // Console.WriteLine("{0}: {1}", triangle, string.Join(",", GetDivisors(triangle)));
            } while (divisors.Count() + 1 < 500);

            Console.WriteLine("{0}: {1}", triangle, string.Join(",", divisors));
            return triangle;
        }

      

        private static List<BigInteger> GetPrimesUsingSieveOfSundaram(int topCandidate = 1000000)
        {
            int totalCount = 0;
            int k = topCandidate / 2;
            var myBa1 = new BitArray(k + 1);

            List<BigInteger> primes = new List<BigInteger>();
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
                    
                    primes.Add((i << 1) + 1);
                    //sum += (i << 1) + 1; // dummy contains prime number.The code is here not ignore the prime number calcuation part.
                }
            }

            return primes;
            //return sum;
            //return (totalCount + 1); // 2 will be missed in Sieve Of Sundaram
        }

        private int GetDivisors(List<BigInteger> primes)
        {
            int t = 1;
            int a = 1;
            int cnt = 0;
            //int i;
            int P = primes.Count;

            while (cnt < 6)
            {
                cnt = 1;
                a = a + 1;
                BigInteger tt = t;
                for (int i = 0; i < P; i++)
                {
                    if (primes[i]*primes[i] > tt)
                    {
                        cnt = 2*cnt;
                        break;
                    }
                    int exponent = 1;
                    while (tt%primes[i] == 0)
                    {
                        exponent++;
                        tt = tt/primes[i];
                    }
                    if (exponent > 1)
                        cnt = cnt*exponent;
                    if (tt == 1)
                        break;
                }
            }
            return t;
        }









        static IEnumerable<int> GetDivisors(int n)
        {
            return Enumerable.Range(2, n/2).Where(a => n%a == 0);
        }


        private int FindTriangularIndex(int factorLimit)
        {
            int n = 1;
            int lnum = NumDivisors(n);
            int rnum = NumDivisors(n + 1);
            while (lnum * rnum < factorLimit)
            {
                n += 1;
                lnum = rnum;
                rnum = NumDivisors(n + 1);
            }
            return n;
        }

        private int NumDivisors(int n)
        {
            if (n%2 == 0)
                n = n/2;
            int divisors = 1;
            int count = 0;
            while (n%2 == 0)
            {
                count++;
                n = n/2;
            }
            divisors = divisors*(count + 1);

            int p = 3;

            while (n != 1)
            {
                count = 0;
                while (n%p == 0)
                {
                    count ++;
                    n = n/p;
                }
                divisors = divisors*(count + 1);
                p += 2;
            }
            return divisors;
        }
    }
}
