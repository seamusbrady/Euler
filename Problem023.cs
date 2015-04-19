using System.Collections.Generic;
using System.Linq;

namespace Euler
{
    class Problem023
    {
        public int Run()
        {
            const int max = 28123;

            var primes = Utility.Prime.GetPrimesUsingSieveOfSundaram(max);
            var abundantNumbers = new List<int>();

            for (int n = 1; n <= max; n++)
            {
                if (primes.Contains(n)) continue;
                var sum = Factors(n);
                if (sum > n)
                {
                    abundantNumbers.Add(n);
                }
            }

            bool[] canBeWrittenasAbundent = new bool[max + 1];
            for (int i = 0; i < abundantNumbers.Count; i++)
            {
                for (int j = i; j < abundantNumbers.Count; j++)
                {
                    if (abundantNumbers[i] + abundantNumbers[j] <= max)
                    {
                        canBeWrittenasAbundent[abundantNumbers[i] + abundantNumbers[j]] = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            int sumOfNonAbundantNumbers = 0;
            for (int i = 1; i <= max; i++)
            {
                if (!canBeWrittenasAbundent[i])
                    sumOfNonAbundantNumbers += i;
            }

            return sumOfNonAbundantNumbers;

        }


        private int Factors(int n)
        {
            //var factor = 1;
            var factors = new List<int>();
            for (int factor = 1; factor <= n / 2; factor++)
            {
                if (n % factor == 0)
                    factors.Add(factor);

            }
            return factors.Sum();
        }
    
    }
}
