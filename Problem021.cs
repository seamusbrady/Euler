using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Euler
{
    class Problem021
    {
        public int Run()
        {
            var primes = Utility.Prime.GetPrimesUsingSieveOfSundaram(10000);

            Debug.Assert(Factors(220) == 284);
            Debug.Assert(Factors(284) == 220);


            var amicableNumbers = new List<int>();

            for (int n = 1; n < 10000; n++)
            {
                if (!primes.Contains(n))
                {
                    var da = Factors(n);
                    var db = Factors(da);
                    if (db == n && db != da)
                        amicableNumbers.Add(n);
                }
            }

            Console.WriteLine(string.Join(", ", amicableNumbers));

            return amicableNumbers.Sum();

        }



        private int Factors(int n)
        {
            //var factor = 1;
            List<int> factors = new List<int>();
            for (int factor = 1; factor <= n / 2; factor++)
            {
                if (n % factor == 0)
                    factors.Add(factor);

            }
            return factors.Sum();
        }
    }
}
