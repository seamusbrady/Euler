using System.Collections.Generic;
using System.Numerics;

namespace Euler
{
    class Problem025
    {
        private readonly Dictionary<int, BigInteger> _fibValues;

        public Problem025()
        {
            _fibValues = new Dictionary<int, BigInteger> { { 1, 1 }, { 2, 1 } };
        }

        public BigInteger Run()
        {
            BigInteger fib;
            int i = 0;
            do
            {
                fib = Fib(++i);
            } while (fib.ToString().Length < 1000);

            return i;
        }

        private BigInteger Fib(int n)
        {
            if (_fibValues.ContainsKey(n))
                return _fibValues[n];

            if (n == 2 || n == 1) return 1;

            var sum = Fib(n - 1) + Fib(n - 2);
            _fibValues[n] = sum;
            return sum;
        }
    }
}
