using System;
using Euler.Utility;

namespace Euler
{
    internal class Problem041
    {
        private static long _maxPrime;

        public long Run()
        {
            var pandigitals = "123456789";
            var pan = new PanDigital {TestFunction = Test};

            do
            {
                Console.WriteLine("Checking " + pandigitals);
                pan.GetPermutations(pandigitals.ToCharArray());
                pandigitals = pandigitals.Substring(0, pandigitals.Length - 1);
            } while (_maxPrime == 0);

            return _maxPrime;

        }
     
        private static bool Test(char[] digits)
        {
            long candidate = ToNumber(digits);

            if (!Prime.IsPrime(candidate)) return false;
            if (candidate > _maxPrime)
            {
                _maxPrime = candidate;
            }
            return true;
        }

        private static long ToNumber(char[] digits)
        {
            long number = 0;
            foreach (var d in digits)
            {
                number += ToInt(d);
                number *= 10;
            }
            number /= 10;
            return number;
        }

        static int ToInt(char d)
        {
            return d - '0';
        }
    }
    
}
