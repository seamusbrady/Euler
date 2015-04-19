using System;
using System.Linq;
using System.IO;

namespace Euler
{
    class Problem067
    {
        public int Run()
        {

            var array = new int[100][];

            string[] data = File.ReadAllLines(@"data\p067_triangle.txt");
            int lineNum = 0;
            foreach (string line in data)
            {
                array[lineNum] = line.Split(' ').Select(int.Parse).ToArray();
                lineNum++;
            }

            for (int i = 1; i < 100; i++)
            {
                int length = array[i].Length;
                for (int j = 0; j < length; j++)
                {
                    var sumLeft = 0;
                    if (j - 1 >= 0)
                    {
                        sumLeft = array[i - 1][j - 1] + array[i][j];
                    }
                    var sumRight = 0;
                    if (j < i)
                    {
                        sumRight = array[i - 1][j] + array[i][j];
                    }

                    array[i][j] = Math.Max(sumLeft, sumRight);
                }

            }

            int max = 0;
            for (int s = 0; s < array[99].Length; s++)
            {
                max = Math.Max(max, array[99][s]);
            }

            return max;
        }
    }
}
