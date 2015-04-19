using System.Collections.Generic;
using Euler.Utility;

namespace Euler
{
    internal class Problem035
    {
        public int Run()
        {
            var primes = Prime.GetPrimesUsingSieveOfSundaram();
            
            //Console.WriteLine(string.Join(", ", primes));

            var circularPrimes = new HashSet<int>();

            foreach (int prime in primes)
            {
                if (prime < 10)
                {
                    circularPrimes.Add(prime);
                    continue;
                }
                
                string candidateString = prime.ToString();

                var isCircularPrime = true;
                for (int i = 1; i < candidateString.Length; i++)
                {
                    var tail = candidateString.Substring(1);
                    var head = candidateString.Substring(0, 1);
                    candidateString = tail + head;
                    var candidate = int.Parse(candidateString);
                    if (!primes.Contains(candidate))
                    {
                        isCircularPrime = false;
                        break;
                    }
                }

                if (isCircularPrime)
                    circularPrimes.Add(prime);
            }
            
            //foreach (var c in circularPrimes)
            //{
            //    Console.Write("{0} ", c);
            //}

            return circularPrimes.Count;
        }



      
    }
}
