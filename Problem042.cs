using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Euler
{
    class Problem042
    {
        public int Run()
        {

            string data = File.ReadAllText(@"data\p042_words.txt");
            var names = data.Replace("\"", "").Split(',');
            var nameList = new List<string>(names);

            const int maxTriangleNumber = 20*26;

            var hashSet = GetTriangleNumbers(maxTriangleNumber);

            return nameList.Select(ScoreWord).Count(hashSet.Contains);
        }

        private int ScoreWord(string word)
        {
            return word.ToCharArray().Sum(c => ToInt(c));
        }


        private HashSet<int> GetTriangleNumbers(int maxTriangleNumber)
        {
            var hashSet = new HashSet<int>();

            int triangleNumber;
            int i = 0;
            do
            {
                i++;
                triangleNumber = (i * (i + 1)) / 2;
                hashSet.Add(triangleNumber);
            } while (triangleNumber < maxTriangleNumber);

            return hashSet;
        }


        static int ToInt(char c)
        {
            return c - '@';
        }
    }
}
