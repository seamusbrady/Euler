using System;
using System.Collections.Generic;

namespace Euler
{
    class Problem034
    {
        public int Run()
        {

            var factorial = new List<int>(10);
            for (int i = 0; i < 10; i++)
            {
                if (i == 0) factorial.Add(1);
                else factorial.Add(factorial[i - 1] * i);
            }


            int upperBound = 7 * factorial[9];

            int result = 0;

            int num = 3;
            do
            {
                var digits = GetIntArray(num);
                var sum = 0;
                foreach (var digit in digits)
                {
                    sum += factorial[digit];
                    if (sum > num) break;
                }

                if (sum == num)
                {
                    result += sum;
                    Console.WriteLine("{0} - {1}", num, sum);
                }
                num++;

            } while (num <= upperBound);

            return result;
        }


        IEnumerable<int> GetIntArray(int num)
        {
            var listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            //listOfInts.Reverse();
            return listOfInts;
        }
        
    }
}
