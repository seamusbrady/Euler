using System;

namespace Euler
{
    class Problem018
    {
        public int Run()
        {

            var array = new int[15][];

            array[0] = new[] { 75 };
            array[1] = new[] { 95, 64 };
            array[2] = new[] { 17, 47, 82 };
            array[3] = new[] { 18, 35, 87, 10 };
            array[4] = new[] { 20, 04, 82, 47, 65 };
            array[5] = new[] { 19, 01, 23, 75, 03, 34 };
            array[6] = new[] { 88, 02, 77, 73, 07, 63, 67 };
            array[7] = new[] { 99, 65, 04, 28, 06, 16, 70, 92 };
            array[8] = new[] { 41, 41, 26, 56, 83, 40, 80, 70, 33 };
            array[9] = new[] { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 };
            array[10] = new[] { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 };
            array[11] = new[] { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 };
            array[12] = new[] { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 };
            array[13] = new[] { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 };
            array[14] = new[] { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 };

            for (int i = 1; i < 15; i++)
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
            for (int s = 0; s < array[14].Length; s++)
            {
                max = Math.Max(max, array[14][s]);
            }

            return max;
        }
    }
}
