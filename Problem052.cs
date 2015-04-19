using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.IO;
using System.Numerics;

namespace Euler
{
    internal class Problem052
    {
        public BigInteger Run()
        {

            BigInteger basen = 10;

            int i = 2;
            var maxX = BigInteger.Divide(BigInteger.Pow(10, i), 6) + 1;
            BigInteger n = basen;

            do
            {

                if (n > maxX)
                {
                    i++;
                    basen = basen*10;
                    n = basen;
                    maxX = BigInteger.Divide(BigInteger.Pow(10, i), 6) + 1;
                }
                else
                {
                    if (HasSameDigits(n))
                        return n;
                    n++;
                }
            } while (true);

        }

        private bool HasSameDigits(BigInteger n)
        {
            var s1 = n.ToString().ToCharArray();
            for (int x = 2; x <= 6; x++)
            {
                if ((n*x).ToString().ToCharArray().Any(c => !s1.Contains(c)))
                    return false;
            }
            return true;
        }

    }
}
