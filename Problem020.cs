using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace Euler
{
    class Problem020
    {
        public int Run()
        {

            Debug.Assert(Factorial(10) == 3628800);

            var num = Factorial(100);
            var chars = num.ToString().ToCharArray();
            var sum = chars.Sum(c => int.Parse(c.ToString()));
            return sum;

        }

        private BigInteger Factorial( int n)
        {
            BigInteger sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
