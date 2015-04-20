using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Euler
{
    class Problem026
    {
        public BigInteger Run()
        {

            const int maxNumerator = 1000;

            var remainders = new Dictionary<int, string>();
            

            for (int divisor = 2; divisor < maxNumerator; divisor++)
            {
                bool done = false;
                int count = 0;
                int dividend = 10;
                string quotientString = "";
                var digits = new List<dynamic>();

                do
                {
                    count++;

                    var quotient = dividend / divisor;
                    var remainder = dividend % divisor;

                    digits.Add(new { Dividend = dividend, Remainder = remainder });
                    var m = digits.Where(p => p.Dividend == dividend && p.Remainder == remainder).ToList();

                    if (m.Count > 1)
                    {
                        done = true;
                    }

                    quotientString += quotient;

                    if (remainder == 0)
                    {
                        done = true;
                    }
                    else
                    {
                        dividend = (dividend % divisor) * 10;
                    }


                } while (!done );

                remainders.Add(divisor, quotientString);

            }

            var maxLength = 0;
            var maxIndex = 0;
            foreach (var kvp in remainders)
            {
                
                if (kvp.Value.Length - 1 > maxLength)
                {
                    maxLength = kvp.Value.Length - 1;
                    maxIndex = kvp.Key;
                    Console.WriteLine("length: {0} {1} - {2}", maxLength, kvp.Key, kvp.Value);
                }
            }

            
            return maxIndex;
        }
     
    }
}
