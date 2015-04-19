using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Euler
{
    class Problem005
    {
        public double Run()
        {
            int k = 20;
            
            return OptimalAlgorithm(k);

            int number = k;
            for (int i = 1; i <= 20; i++)
            {
                int remainder = number % i;

                if (remainder != 0)
                {
                    number = number + 20;
                    i = 1;
                }
            }

            return number;
        }


        private double OptimalAlgorithm(int k = 20)
        {
            
            double N = 1;
            int i = 0;
            bool check = true;
            double limit = Math.Sqrt(k);

            List<int> primes = Utility.Prime.GetPrimesUsingSieveOfSundaram(k).ToList();

            while (i < primes.Count() && primes[i] < k)
            {
                var ai = 1;
                if (check)
                {
                    if (primes[i] <= limit)
                    {
                        ai = (int) Math.Floor(Math.Log10(k)/Math.Log10(primes[i]));
                    }
                    else
                    {
                        check = false;
                    }
                }
                N = N*Math.Pow(primes[i], ai);

                i++;
            }

            return N;
        }



    }
}
