using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.IO;
using System.Numerics;

namespace Euler
{
    class Problem056
    {
        public long Run()
        {
            return SolutionWeb();
            return RunMySolution();
        }

        private int SolutionWeb()
        {
            var maxSum = 0;
            for (var a = 90; a < 100; a++)
            {
                for (var b = 1; b < 100; b++)
                {
                    var sum = BigInteger.Pow(a, b).ToString(CultureInfo.InvariantCulture).Sum(c => c - 48);
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }
            return maxSum;

        }

        private long RunMySolution()
        {
            const int max = 99;

            Debug.Assert(CalculateSum("100") == 1);
            Debug.Assert(CalculateSum("111") == 3);
            Debug.Assert(CalculateSum("1234") == 10);
            Debug.Assert(CalculateSum("0123456789") == 45);

            var maxDigitSum = 0;
            var maxA = 0;
            var maxB = 0;



            for (int a = 90; a <= max; a++)
            {
                BigInteger pow = 1;
                for (int b = 1; b <= max; b++)
                {
                    pow = (pow * a);
                    

                    var sum = CalculateSum(pow.ToString());
                    if (sum > maxDigitSum)
                    {
                        maxDigitSum = sum;
                        maxA = a;
                        maxB = b;
                       // Console.WriteLine("{0}^{1} = {2}", a, b, pow);
                    }
                }

                
            }

            //for (int a = max; a > 1; a--)
            //{
            //    BigInteger pow = 1;
            //    for (int b = max; b >= 1; b--)
            //    {
            //        pow = (pow*a);
            //    }

            //    var sum = CalculateSum(pow.ToString());
            //    if (sum > maxDigitSum)
            //        maxDigitSum = sum;
            //}

            return maxDigitSum;
        }
        
        private static int CalculateSum(string name)
        {
            char[] chars = name.ToCharArray();
            var sum = chars.Sum(c => ToInt(c));
            return sum;
        }

        static int ToInt(char c)
        {
            return c - '0';
        }
        
    }
}
