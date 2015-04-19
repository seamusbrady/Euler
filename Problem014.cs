using System;
using System.Numerics;

namespace Euler
{
    class Problem014
    {
        public string Run()
        {
            const int maxIterations = 1000000;
            var longest = 0;
            var longestSequenceCount = 0;
            for (int i = 2; i < maxIterations; i++)
            {
                BigInteger n = i;
                var sequenceCount = 1;
                do
                {
                    sequenceCount++;

                    if (IsOdd(n))
                        n = 3*n + 1;
                    else
                        n = n/2;
                } while (n > 1);

                if (sequenceCount > longestSequenceCount)
                {
                    Console.WriteLine("# {0}, length: {1}", i, sequenceCount);
                    longestSequenceCount = sequenceCount;
                    longest = i;
                }
            }


            return longest.ToString();
        }

        private static bool IsOdd(BigInteger value)
        {
            return value % 2 != 0;
        }

        
    }


}
