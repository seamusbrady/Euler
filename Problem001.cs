namespace Euler
{
    class Problem001
    {
        /// <summary>
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        public int Run()
        {
            const int multipleBelowValue = 1000;

            int max = multipleBelowValue - 1;
            return SumDivisibleBy(max, 3) + SumDivisibleBy(max, 5) - SumDivisibleBy(max, 15);
        }

        private int SumDivisibleBy(int target, int n)
        {
            int p = target/n;
            return n*(p*(p + 1))/2;
        }

    }
}
