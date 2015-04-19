namespace Euler
{
    class Problem028
    {
        public int Run()
        {
            var sum = 1;
            for (int spiralDimension = 3; spiralDimension < 1002; spiralDimension += 2)
            {
                var width = spiralDimension - 1;

                var topRight = spiralDimension * spiralDimension;
                var topLeft = topRight - width;
                var bottomLeft = topLeft - width;
                var bottomRight = bottomLeft - width;

                sum += bottomRight + bottomLeft + topLeft + topRight;
            }
            return sum;
        }
    }
}
