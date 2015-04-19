using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler
{
    class Problem029
    {
        public int Run()
        {
            //return RunNotCorrect();
            //return BruteForce1();
            //return BruteForce2();
            return SolutionFloydCrimson();
        }



        const int Size = 99;
        readonly bool[,] _boolArray = new bool[Size, Size];


        private void SetValue(int i, int j, bool value)
        {
            _boolArray[i - 2, j - 2] = value;
        }

        private bool GetValue(int i, int j)
        {
            return _boolArray[i - 2, j - 2];
        }

        public int RunNotCorrect()
        {
            for (int i = 2; i < Size + 2; i++)
                for (int j = 2; j < Size + 2; j++)
                    SetValue(i, j, true);


            var primes = GetPrimes();

            for (int i = 2; i < Size + 2; i++)
            {
                for (int j = 2; j < Size + 2; j++)
                {
                    if (GetValue(i, j) == false) continue;
                    if (primes.Contains(i))
                    {
                        int k = i;
                        int p = j;
                        while (p > k && p % k == 0)
                        {
                            k = k * k;
                            p = p / 2;
                            if (k < 2 || k > Size || p < 2 || p > Size)
                                break;
                            Console.WriteLine("{0}^{1}", k, p);
                            SetValue(k, p, false);
                        }
                    }
                }
            }


            var count = 0;
            for (int i = 2; i < Size + 2; i++)
            {
                for (int j = 2; j < Size + 2; j++)
                {
                   // Console.Write("{0}^{1} ", i, j);
                    if (GetValue(i, j))
                        count ++;
                }
             //   Console.WriteLine();

            }
            return count;


        }



        private HashSet<int> GetPrimes()
        {
            var primes = new HashSet<int>();


            for (int i = 2; i <= 100; i++)
            {
                if (IsPrime(i))
                    primes.Add(i);
            }
            return primes;
        }

        private static bool IsPrime(int n)
        {
            if (n == 1) return false;
            if (n < 4) return true;
            if (n % 2 == 0) return false;
            if (n < 9) return true;
            if (n % 3 == 0) return false;

            var r = Math.Floor(Math.Sqrt(n));
            var f = 5;
            do
            {
                if (n % f == 0) return false;
                if (n % (f + 2) == 0) return false;
                f = f + 6;
            } while (f <= r);

            return true;

        }


        private int BruteForce1()
        {
            var set = new List<double>();

            for (int a = 2; a <= 100; a++)
            {
                for (int b = 2; b <= 100; b++)
                {
                    double result = Math.Pow(a, b);
                    if (!set.Contains(result))
                    {
                        set.Add(result);
                    }
                }
            }
            return set.Distinct().Count();

        }

        private int BruteForce2()
        {
            var set = new SortedSet<double>();

            for (int a = 2; a <= 100; a++)
            {
                for (int b = 2; b <= 100; b++)
                {
                    double result = Math.Pow(a, b);
                    set.Add(result);
                }
            }

            return set.Count();
        }


        private int SolutionFloydCrimson()
        {
            var bases = new int[101, 2];
            for (int number = 2; number <= 100; number++)
            {
                int pow = number;
                for (int exp = 1; pow < bases.GetLength(0); exp++, pow *= number)
                    if (bases[pow, 0] == 0)
                    {
                        bases[pow, 0] = number;
                        bases[pow, 1] = exp;
                    }
            }

            var pows = new List<int>[101];
            for (int index = 0; index < pows.Length; index++)
                pows[index] = new List<int>();

            for (int a = 2; a <= 100; a++)
                for (int b = 2; b <= 100; b++)
                {
                    int exp = bases[a, 1] * b;
                    if (!pows[bases[a, 0]].Contains(exp))
                        pows[bases[a, 0]].Add(exp);
                }

            int sum = 0;
            foreach (List<int> list in pows)
                sum += list.Count;

            return sum;
        }



    }
}
