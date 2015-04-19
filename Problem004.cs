using System.Linq;
using System.Numerics;

namespace Euler
{
    class Problem004
    {
        public BigInteger Run()
        {
            var maxPalindrome = 0;

            for (int i = 999; i >= 100; i--)
            {
                for (int j = 999; j >= 100; j--)
                {
                    var product = i*j;
                    if (!IsPalindrome(product.ToString())) continue;

                    if (product > maxPalindrome)
                        maxPalindrome = product;
                    else
                        break;
                }
            }
            return maxPalindrome;
        }

        private bool IsPalindrome(string num)
        {
            return num.SequenceEqual(num.Reverse());
        }


    }

}
