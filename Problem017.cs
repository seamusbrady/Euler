using System;
using System.Linq;

namespace Euler
{
    internal class Problem017
    {
        public int Run()
        {

            var ones = new[] {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            var teens = new[]{ "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen","nineteen"};
            var tens = new[] {"", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};

            var total = 0;
            for (int i = 1; i < 1000; i++)
            {

                var chars = i.ToString().PadLeft(3, '0').ToCharArray().Select(c => int.Parse(c.ToString())).ToList();
                var str = "";

                if (i > 99)
                {
                    str += ones[chars[0]] + "hundred";

                    if (i%100 > 0)
                        str += "and";
                }

                if (i%100 >= 10 && i%100 < 20)
                {
                    str += teens[chars[2]];
                }
                else
                {
                    str += tens[chars[1]];
                    str += ones[chars[2]];
                }

                total += str.Length;


                Console.WriteLine("i = " + i + " sum = " + str.Length + " total = " + total + ", " + str);
            }
            return total + "onethousand".Length;
        }
    }
}
