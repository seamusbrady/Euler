using System.Collections.Generic;
using System.Numerics;

namespace Euler
{
    class Problem003
    {
        public BigInteger Run()
        {
            long number = 600851475143;

            var primes = Utility.Prime.GetPrimesUsingSieveOfSundaram();

            var maxFactor = 1;

            foreach (var prime in primes)
            {
                if (number%prime == 0)
                {
                    if (prime > maxFactor)
                        maxFactor = prime;
                    number = number/prime;
                }
            }

            return maxFactor;
        }

      
    }
}
