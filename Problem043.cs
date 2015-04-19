using System;
using System.Linq;
using System.Numerics;

namespace Euler
{
    internal class Problem043
    {
        public BigInteger Run()
        {
            
            var primes = Utility.Prime.GetPrimesUsingSieveOfSundaram(1000);


            int number = 406357289;
            int len = (int) Math.Log10(number);
            Console.WriteLine("len = {0}", len);

            int min = 100000000;
            int max = 999999999;

            int[] divisors = { 1, 2, 3, 5, 7, 11, 13, 17 };

            for (int candidate = min; candidate <= max; candidate++)
            {
            }

            for (int i = 0; i < len - 1; i++)
            {
                int power = (int) Math.Pow(10, len - 3 - i + 1);

                int part = number/power;
                int section = part % 1000;
                if (primes.Contains(section))
                    break;

                Console.WriteLine("i={3}: {0} / {1} = {2}, section = {4}, isPrime: {5}", number, power, part, i, section, primes.Contains(section));

            }



            return 0;
        }

    }
}
