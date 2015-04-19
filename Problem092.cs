using System;
using System.Linq;
using System.IO;

namespace Euler
{
    class Problem092
    {

        public int Run()
        {
            //return ComputeAll();

            int total = 0;
            for (int i = 2; i < 10000000; i++)
                total += ConvertAll(i);
            return total;
        }

        private int ConvertAll(int n)
        {
            int newNum = n;
            do
            {
                newNum = ComputeNext(newNum);
                if (newNum == 1)
                    return 0;
                else if (newNum == 89)
                    return 1;

            } while (true);
        }


        private static readonly int[] Multiples = { 0, 1, 4, 9, 16, 25, 36, 49, 64, 81 };

        private static int ComputeNext(int k)
        {
            int sum = 0;
            while (k > 9)
            {
                sum += Multiples[k % 10];
                k /= 10;
            }
            return sum + Multiples[k];
        }


        private static int ComputeAll()
        {
            int count = 0;
            for (int i = 2; i <= 10000000; i++)
            {
                int val = ComputeNext(i);
                while (val != 1)
                {
                    val = ComputeNext(val);
                    if (val != 89) continue;
                    count++;
                    break;
                }
            }
            return count;
        }

      
     
    }
}
