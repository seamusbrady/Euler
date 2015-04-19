using System;

namespace Euler
{
    internal class Problem033
    {
        public int Run()
        {

            var numeratorProduct = 1;
            var demoninatorProduct = 1;

            for (int numerator = 10; numerator <= 99; numerator++)
            {
                for (int demoninator = numerator + 1; demoninator < 99; demoninator++)
                {
                    
                    if (numerator%10 == 0 || demoninator%10 == 0)
                        continue;
                    if (numerator % 11 == 0 && demoninator % 11 == 0)
                        continue;

                    double fraction = (numerator * 1.0) / demoninator;

                    var nl = numerator/10;
                    var nr = numerator%10;
                    var dl = demoninator/10;
                    var dr = demoninator%10;

                    double flr = (nl*1.0)/dr;

                    if (Math.Abs(fraction - flr) < 0.00001  && nr== dl)
                    {
                        Console.WriteLine("Fraction LR {0}/{1} and {2}/{3}", numerator, demoninator, nl, dr);
                        numeratorProduct *= numerator;
                        demoninatorProduct *= demoninator;
                    }

                    //double frl = (nr * 1.0) / dl;
                    //if (Math.Abs(fraction - frl) < 0.00001 && nl == dr)
                    //{
                    //    Console.WriteLine("Fraction RL {0}/{1} and {2}/{3}", numerator, demoninator, nr, dl);
                    //    numeratorProduct *= numerator;
                    //    demoninatorProduct *= demoninator;
                    //}

                }

            }



            return demoninatorProduct / GreatestCommonDivisor(numeratorProduct, demoninatorProduct);
        }

        static int GreatestCommonDivisor(int a, int b)
        {
            return b == 0 ? a : GreatestCommonDivisor(b, a % b);
        }
        
    }
}