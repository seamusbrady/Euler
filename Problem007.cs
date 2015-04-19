using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// What is the 10 001st prime number?
    /// </summary>
    class Problem007
    {
        public int Run()
        {
            Debug.Assert(IsPrime(7));
            Debug.Assert(IsPrime(101));
            Debug.Assert(!IsPrime(100));


            const int limit = 10001;
            int count = 1;
            int canditate = 1;
            do
            {
                canditate += 2;
                if (IsPrime(canditate))
                    count++;
            } while (count != limit);

            return canditate;
        }

        

        private static bool IsPrime(int n)
        {
            if (n == 1) return false;
            if (n < 4) return true;
            if (n%2 == 0) return false;
            if (n < 9) return true;
            if (n%3 == 0) return false;

            var r = Math.Floor(Math.Sqrt(n));
            var f = 5;
            do
            {
                if (n%f == 0) return false;
                if (n%(f + 2) == 0) return false;
                f = f + 6;
            } while (f <= r);

            return true;
        }

    }
}
