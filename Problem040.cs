using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Euler
{
    class Problem040
    {

        public int Run()
        {

             int digitLength = 0;
            var decpositions = new List<Decpos>();

            int culumativeLength = 0;
            for (int i = 1; i <= 100000; i = i*10)
            {
                int numNumbers = (i*10 - 1) - i +1;
                int lengthDigits = numNumbers*i.ToString().Length;
                int minLength = culumativeLength + 1;
                culumativeLength += lengthDigits;

                decpositions.Add(new Decpos
                {
                    DigitLength = ++digitLength,
                    MinRange = i,
                    MinLength = minLength,
                    MaxLength = culumativeLength
                });
                
            }


            int[] digitPositions = { 10, 100, 1000, 10000, 100000, 1000000 };
            var answers = new List<int>();
            var product = 1;

            foreach (var digitPosition in digitPositions)
            {
                foreach (var decpos in decpositions)
                {
                    if (decpos.MaxLength < digitPosition)
                        continue;

                    int num = digitPosition - decpos.MinLength;
                    num = num/decpos.DigitLength;
                    int offset = num%decpos.DigitLength;

                    int actualNumber = decpos.MinRange + num;
                    string digit = actualNumber.ToString().Substring(offset, 1);
                    Console.WriteLine("Character at position {0} is {1}", digitPosition, digit);
                    answers.Add(int.Parse(digit));
                    product = product*int.Parse(digit);
                    break;
                }
            }

            return product;
        }

        private class Decpos
        {
            public int DigitLength;
            public int MinLength;
            public int MaxLength;
            public int MinRange;
        }


        private void WriteSeries()
        {
            for (int j = 1; j < 200; j++)
            {
                if (j < 10)
                    Console.WriteLine("{0}\t{1}", j, j);
                else
                {
                    int pos = j - 10;
                    int a = pos / 2;
                    string num = (a + 10).ToString();
                    int b = pos % 2;

                    Console.WriteLine("{0}\t{1}", j, num.Substring(b, 1));
                }
            }
        }
    }
}
