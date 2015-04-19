using System.Linq;
using System.Numerics;

namespace Euler
{
    internal class Problem050
    {
        public BigInteger Run()
        {
            return FindPrimSum();
        }

        private int FindPrimSum(int max = 1000000)
        {
            var primes = Utility.Prime.GetPrimesUsingSieveOfSundaram();
            var primeList = primes.ToList();

            int maxPrimeSum = 0;

            int sp = 0;
            int p = 0;
            do
            {
                sp += primeList[p];
                p++;
            } while (sp < max);

            int numPrimes = p;


            for (int sumLength = 2; sumLength < numPrimes; sumLength++)
            {
                for (int i = 0; i < numPrimes - sumLength + 1; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < sumLength; j++)
                    {
                        sum += primeList[i + j];
                    }
                    if (sum > max)
                        break;

                    if (!primes.Contains(sum)) continue;
                    maxPrimeSum = sum;
                    break;
                }
            }

            return maxPrimeSum;
        }
    }
}
