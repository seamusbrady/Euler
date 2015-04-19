using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler
{
    class Problem030
    {
        public int Run()
        {
            var powersOf5 = new List<int>(10);
            for (int i = 0; i < 10; i++)
            {
                if (i == 0) powersOf5.Add(0);
                else powersOf5.Add((int) Math.Pow(i, 5));
            }

            // To find upper bound
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} - {1}", "".PadLeft(i, '9'), powersOf5[9] * i);
            }
            int upperBound = 6 * powersOf5[9];

            int result = 0;

            int num = 2;
            do
            {
                var digits = GetIntArray(num);
                var sum = 0;
                foreach (var digit in digits)
                {
                    sum += powersOf5[digit];
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
