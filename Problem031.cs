using System.Collections.Generic;

namespace Euler
{
    internal class Problem031
    {
        public int Run()
        {
            
            return BetterSolution();

            const int num100 = 2;
            const int num50 = 4;
            const int num20 = 10;
            const int num10 = 20;
            const int num5 = 40;
            const int num2 = 100;
            const int num1 = 200;

            int count = 1; // 1 £2 coin

            for (int b = 0; b <= num100; b++)
            {
                for (int c = 0; c <= num50; c++)
                {
                    for (int d = 0; d <= num20; d++)
                    {
                        for (int e = 0; e <= num10; e++)
                        {
                            for (int f = 0; f <= num5; f++)
                            {
                                for (int g = 0; g <= num2; g++)
                                {
                                    for (int h = 0; h <= num1; h++)
                                    {
                                        int sum = 100*b + 50*c + 20*d + 10*e + 5*f + 2*g + h;
                                        if (sum == 200)
                                        {
                                            //Console.WriteLine("Combination: 200x{0}, 100x:{1}, 50p: {2}", a, b, c);
                                            count++;
                                            break;
                                        }
                                        if (sum > 200)
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return count;
        }

        public int BetterSolution()
        {
            int m = 200;
            int count = 0;
            int a, b, c, d, e, f, g;
            for (a = m; a >= 0; a -= 200)
                for (b = a; b >= 0; b -= 100)
                    for (c = b; c >= 0; c -= 50)
                        for (d = c; d >= 0; d -= 20)
                            for (e = d; e >= 0; e -= 10)
                                for (f = e; f >= 0; f -= 5)
                                    for (g = f; g >= 0; g -= 2)
                                        count++;
            return count;
        }

    }
}