using System;
using System.Linq;
using System.IO;

namespace Euler
{
    class Problem099
    {
        public int Run()
        {

            string[] data = File.ReadAllLines(@"data\p099_base_exp.txt");
            int lineNum = 0;

            int maxLineNum = 0;
            double max = 0;

            foreach (string line in data)
            {
                var nums = line.Split(',').Select(int.Parse).ToArray();
                double result = Math.Log(nums[0])*nums[1];
                if (result > max)
                {
                    max = result;
                    maxLineNum = lineNum + 1;
                }
                lineNum++;
            }

            return maxLineNum;
        }
    }
}
