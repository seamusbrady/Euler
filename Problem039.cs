namespace Euler
{
    class Problem039
    {
        public int Run()
        {
            int maxP = 0;
            int maxTriangles = 0;

            for (int p = 3; p <= 1000; p++)
            {
                int numTriangles = 0;
                for (int a = 1; a <= p - 2; a++)
                {
                    for (int b = a; b <= p - 2* a; b++)
                    {
                        int c = p - b - a;
                        if (a*a + b*b == c*c)
                        {
                            numTriangles++;
                            //Console.WriteLine("Triange {0}-{1}-{2} p = {3}", a, b, c, p);
                        }
                    }
                }

                if (numTriangles > maxTriangles)
                {
                    maxTriangles = numTriangles;
                    maxP = p;
                 //   Console.WriteLine("Max: {0} - {1} trianlges", p, numTriangles);
                }
            }

            return maxP;
        }




    }
}
