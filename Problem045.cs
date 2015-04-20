using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler
{
    internal class Problem045
    {


        public long Run()
        {

            //return TestRun();

            var triangleNumbers = new Dictionary<long, long>();
            var pentagonalNumbers = new HashSet<long>();
            var hexagonalNumbers = new HashSet<long>();

            for (long i = 2; i <= 100000; i++)
            {
                triangleNumbers.Add(i, (i*(i + 1))/2);
                pentagonalNumbers.Add((i*(3*i - 1))/2);
                hexagonalNumbers.Add(i*(2*i - 1));
            }

            var found = triangleNumbers.FirstOrDefault(t => pentagonalNumbers.Contains(t.Value) && hexagonalNumbers.Contains(t.Value) && t.Key != 285);
            
            return found.Value;

        }


        private long TestRun()
        {
            int n = 144;
            int i = 165;
            long p = i*(3*i - 1)/2;
            long h = n*(2*n - 1);

            while (p != h)
            {
                n++;
                h = n*(2*n - 1);
                while (h > p)
                {
                    i++;
                    p = i*((3*i - 1)/2);
                }
            }
            Console.WriteLine("the next triangular number is {0}. i={1}, n={2}", h, i, n);
            return h;
        }

    }
}
