using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem024
    {
        public BigInteger Run()
        {

            //return GetIndex(7, new List<int> { 1, 2, 3, 4});
            return GetIndex(1000000, new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            
            //var numRuns = Factorial(4);
            //for (int i = 1; i < numRuns; i++)
            //{
            //    var nums = new List<int>() { 1, 2, 3, 4 };
            //    var x = GetIndex(i, nums);
            //    Console.WriteLine(x);
            //}
            //return 0;
        }

        private BigInteger GetIndex(int targetIndex, List<int> nums)
        {
            var maxIndex = nums.Count();
            var result = new List<int>();

            int currentPos = 0;

            // PreCalculate factorials
            var factorial = new List<int>(10);
            for (int i = 0; i < maxIndex; i++)
            {
                if (i == 0) factorial.Add(1);
                else factorial.Add(factorial[i - 1] * i);
            }

            for (int p = maxIndex; p > 0; p--)
            {
                //int step = Factorial(p - 1);
                int step = factorial[p - 1];
                //Console.WriteLine("Step: {0}, fact: {1}",step, facts[p-1]);
                int power = 0;
                while (currentPos + (step * (power + 1)) < targetIndex)
                {
                    power++;
                }

                currentPos = currentPos + (step * (power));

                result.Add(nums[power]);
                nums.RemoveAt(power);

                //if (currentPos >= targetIndex)
                //{
                //    result.AddRange(nums);
                //    break;
                //}
            }

            return BigInteger.Parse(string.Join("", result));
        }



        //private static int Factorial(int a)
        //{
        //    if (a <= 1)
        //    {
        //        return 1;
        //    }
        //    return a * Factorial(a - 1);
        //}

    }


}
