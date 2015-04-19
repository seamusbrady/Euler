using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem016
    {
        public int Run()
        {
            var num = new BigInteger(Math.Pow(2, 1000));
            var chars = num.ToString().ToArray();
            var digits = chars.Select(c => int.Parse(c.ToString())).ToList();
            return digits.Sum();
        }
    }
}
