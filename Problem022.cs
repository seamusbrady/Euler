using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem022
    {
        public int Run()
        {

            string data = File.ReadAllText(@"data\p022_names.txt");
            var names = data.Replace("\"", "").Split(',');
            var nameList = new List<string>(names);
            nameList.Sort();

            var total = 0;
            var i = 0;

            
            var colin = nameList[938 - 1];
            var colinTotal = CalculateScoreForName(colin, 938);
            Debug.Assert(colinTotal == 49714);

            foreach (var name in nameList)
            {
                i++;
                total += CalculateScoreForName(name, i);
            }
            return total;
        }

        private static int CalculateScoreForName(string name, int i)
        {
            char[] chars = name.ToCharArray();
            var sum = chars.Sum(c => ToInt(c));
            return sum*i;
        }

        static int ToInt(char c)
        {
            return c - '@';
        }
    }
}
