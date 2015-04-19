using System;
using System.Collections.Generic;
using System.Linq;
using Euler.Utility;

namespace Euler
{
    internal class Problem046
    {


        public long Run()
        {
            // return Solution();
            return RunMySolution();
        }

        public static long Solution()
        {
            List<int> primes = new List<int>() { 2 };
            for (int number = 3; true; number += 2)
            {
                bool isPrime = true;
                int prime_limit = (int)Math.Sqrt(number) + 1;
                for (int index = 0; isPrime && index < primes.Count && primes[index] <= prime_limit; index++)
                    isPrime &= number % primes[index] != 0;
                if (isPrime)
                    primes.Add(number);
                else
                {
                    bool check = false;
                    for (int primes_index = 1; !check && primes_index < primes.Count; primes_index++)
                        check |= Math.Sqrt((number - primes[primes_index]) / 2) % 1 == 0;
                    if (!check)
                        return number;
                }
            }
            throw new Exception("Number not found");
        }


        private long RunMySolution()
        {
            var primes = Prime.GetPrimesUsingSieveOfSundaram();
            var set = new SortedSet<int>();
            foreach (var prime in primes)
            {
                set.Add(prime);
            }

            var squares = new HashSet<long>();
            for (int i = 1; i < 1000000; i++)
            {
                long l = i;
                squares.Add(l*l);
            }

            bool found = false;
            int number = 7;
            do
            {
                number += 2;
                if (primes.Contains(number))
                    continue;

                int max = number;
                var pp = set.Where(p => p < max);

                bool isOK = pp.Select(p => (number - p)/2).Any(x => squares.Contains(x));

                //Console.WriteLine("{0} = {1} + 2*{2}^2", number, prime, Math.Sqrt(square));
                if (isOK == false)
                    found = true;

            } while (!found);

            return number;
        }



    }
}
