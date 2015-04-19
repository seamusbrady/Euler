namespace Euler
{
    internal class Problem048
    {
        public long Run()
        {
            const int max = 1000;
            long sum = 0;
            for (int i = 1; i <= max; i++)
            {
                long pow = i;
                for (int j = 1; j < i; j++)
                {
                    pow = (pow * i) % 100000000000;
                }
                
                sum = sum + pow;
            }
            return sum;
        }



    }
}
