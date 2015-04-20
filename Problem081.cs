using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Euler
{
    class Problem081
    {
        public int Run()
        {
            string[] data = File.ReadAllLines(@"data\p081_matrix.txt");

            List<int> previousLine = null;
            List<int> currentLine = null;

            foreach (string line in data)
            {
                currentLine = line.Split(',').Select(int.Parse).ToList();

                for (int i = 1; i < currentLine.Count; i++)
                {
                    if (i == 1)
                        currentLine[i - 1] += (previousLine != null ? previousLine[i - 1] : 0);
                    
                    var leftNum = currentLine[i - 1];
                    var topNum = previousLine != null ? previousLine[i] : 9999999;
                    var currentNum = currentLine[i];
                    if (leftNum + currentNum < topNum + currentNum)
                        currentLine[i] += leftNum;
                    else
                        currentLine[i] += topNum;
                }
                previousLine = currentLine;

            }
            return currentLine.Last();

         
        }
    }
}
