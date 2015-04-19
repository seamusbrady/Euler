namespace Euler
{
    class Problem006
    {
        public int Run()
        {
            int sumSquares = 0;
            int sumNumbers = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumSquares += i*i;
                sumNumbers += i;
            }
            return (sumNumbers * sumNumbers) - sumSquares;
        }
    }
}
