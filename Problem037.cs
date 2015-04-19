using System;
using System.Collections.Generic;
using Euler.Utility;

namespace Euler
{
    internal class Problem037
    {
        public int Run()
        {
            var primes = Prime.GetPrimesUsingSieveOfSundaram();


            var truncatablePrimes = new HashSet<int>();

            foreach (int prime in primes)
            {
                if (prime < 10)
                {
                    continue;
                }

                string candidateStringLeft = prime.ToString();
                string candidateStringRight = candidateStringLeft;

                var isTrunctablePrime = true;
                var length = candidateStringLeft.Length;
                for (int i = 1; i < length; i++)
                {
                    var leftFragment = candidateStringLeft.Substring(0, length - i);
                    var rightFragment = candidateStringRight.Substring(i);

                    var candidateLeft = int.Parse(leftFragment);
                    if (!primes.Contains(candidateLeft))
                    {
                        isTrunctablePrime = false;
                        break;
                    }

                    var candidateRight = int.Parse(rightFragment);
                    if (!primes.Contains(candidateRight))
                    {
                        isTrunctablePrime = false;
                        break;
                    }

                }

                if (isTrunctablePrime)
                    truncatablePrimes.Add(prime);

                if (truncatablePrimes.Count == 11)
                    break;
            }

            var sum = 0;
            foreach (var c in truncatablePrimes)
            {
                sum += c;
                Console.Write("{0} ", c);
            }

            return sum;
        }



      
    }
}
