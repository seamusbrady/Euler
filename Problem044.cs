using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler
{
    internal class Problem044
    {
        public long Run()
        {

            //return TestRun();

            var pentagonalNumbers = new Dictionary<long, long>();
            var pentagonalNumbersSet = new HashSet<long>();

            for (long i = 2; i <= 5000; i++)
            {
                pentagonalNumbers.Add(i,(i*(3*i - 1))/2);
                pentagonalNumbersSet.Add((i * (3 * i - 1)) / 2);
            }

            for (int i = 2; i < pentagonalNumbers.Count; i++)
            {
                for (int j = i+1; j < pentagonalNumbers.Count; j++)
                {
                    var pPlus = pentagonalNumbers[i] + pentagonalNumbers[j];
                    var pMinus = pentagonalNumbers[j] - pentagonalNumbers[i];
                    if (pentagonalNumbersSet.Contains(pPlus) && pentagonalNumbersSet.Contains(pMinus))
                    {
                        return pMinus;
                    }
                }
            }
            return 0;
        }
    }
}
