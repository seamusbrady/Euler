using System;

namespace Euler
{
    class Problem027
    {
        public int Run()
        {
            var primes = Utility.Prime.GetPrimesUsingSieveOfSundaram();

            var max = 1000;
            var min = max * -1;

            var maxSequence = 0;
            var maxA = 0;
            var maxB = 0;

            for (int a = min; a < max; a++)
            {
                for (int b = min; b < max; b++)
                {
                    bool isPrime = true;
                    int n = 0;
                    int numPrimesInSequence = 0;
                    do
                    {
                        var candidate = n*n + a*n + b;
                        if (primes.Contains(candidate))
                        {
                            numPrimesInSequence++;
                        }
                        else
                        {
                            isPrime = false;
                            if (numPrimesInSequence > maxSequence)
                            {
                                maxA = a;
                                maxB = b;
                                maxSequence = numPrimesInSequence;
                            }
                        }
                        n++;
                    } while (isPrime);
                }
            }

            Console.WriteLine("a:{0}, b: {1}, num in sequence: {2}", maxA, maxB, maxSequence);
            return maxA * maxB;
        }

    }
}
