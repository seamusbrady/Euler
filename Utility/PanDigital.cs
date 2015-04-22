using System;
using System.Collections.Generic;

namespace Euler.Utility
{
    internal class PanDigital
    {
        //public bool StopProcessing { get; set; }
        public PanDigital()
        {
            TestFunction = Test;
        }

        private bool Test(char[] pandigital)
        {
            Console.WriteLine(pandigital);
            return true;
        }

        public Func<char[], bool> TestFunction { get; set; }
        public bool Result { get; private set; }
  
        public void GetPermutations(char[] list)
        {
            int x = list.Length - 1;
            GetPermutations(list, 0, x);
        }


        private void GetPermutations(char[] list, int k, int m)
        {
            if (k == m)
            {
                Result = TestFunction(list);
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPermutations(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }

        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }

    }
}
