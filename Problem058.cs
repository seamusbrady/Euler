using System;
using Euler.Utility;

namespace Euler
{
    class Problem058
    {
        public int Run()
        {
            int numPrimes = 0;
            int numCorners = 1;
            int spiralDimension = 3;

            do
            {
                var width = spiralDimension - 1;

                var bottomRight = spiralDimension * spiralDimension;
                var bottomLeft = bottomRight - width;
                var topLeft = bottomLeft - width;
                var topRight = topLeft - width;

                if (Prime.IsPrime(topLeft)) numPrimes++;
                if (Prime.IsPrime(topRight)) numPrimes++;
                if (Prime.IsPrime(bottomLeft)) numPrimes++;

                numCorners += 4;

                double ratio = (100.0 * numPrimes) / numCorners;

                if (ratio < 10)
                {
                    Console.WriteLine("Ratio {0}/{1} = {2}", numPrimes, numCorners, ratio);
                    Console.WriteLine("TL:{0}, TR:{1}", topLeft, topRight);
                    Console.WriteLine("BL:{0}, BR:{1}", bottomLeft, bottomRight);
                    break;
                }

                spiralDimension += 2;

            } while (true);

            return spiralDimension;
        }
    }
}
