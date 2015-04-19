﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem002
    {
       private readonly Dictionary<int, BigInteger> _fibValues;


       /// <summary>
       /// Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
       /// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
       /// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
       /// </summary>
        public Problem002()
        {
            _fibValues = new Dictionary<int, BigInteger> { { 1, 1 }, { 2, 1 } };
        }

        public BigInteger Run()
        {
            // return Solution1();
            return Solution2();
        }

        private BigInteger Fib(int n)
        {
            if (_fibValues.ContainsKey(n))
                return _fibValues[n];

            if (n == 2 || n == 1) return 1;

            var sum = Fib(n - 1) + Fib(n - 2);
            _fibValues[n] = sum;
            return sum;
        }


        private BigInteger Solution1()
        {
            BigInteger sum = 0;
            BigInteger fib;
            int i = 0;
            do
            {
                fib = Fib(++i);
                if (fib % 2 == 0)
                    sum += fib;

            } while (fib < 4000000);

            return sum;
        }

        private int Solution2()
        {
            const int limit = 4000000;
            int sum = 0;
            int a = 1;
            int b = 1;
            int c = a + b;
            do
            {
                sum = sum + c;
                a = b + c;
                b = c + a;
                c = a + b;
            } while (c < limit);

            return sum;
        }

      
    }
}