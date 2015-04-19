using System;
using System.Numerics;

namespace Euler
{
    class Problem100
    {
        public BigInteger Run()
        {

            //BigInteger blue = 10;
            //BigInteger red = 4;
            //BigInteger total = 1000000000000;
            //BigInteger blue = BigInteger.Divide(total * 7, 10) - 1;
            //BigInteger red = BigInteger.Divide(total * 3, 10) - 1;
            BigInteger blue = 705330003554;
            BigInteger red = 299999999999;

            
            do
            {
                var top = blue*(blue - 1);
                var bottom = (blue + red)*(blue + red - 1);


                BigInteger remainder;
                BigInteger result = BigInteger.DivRem(bottom, top, out remainder);

                //Console.WriteLine("Blue: {0} Red: {1}, Ratio: {2}, remainer: {3}", blue, red, result, remainder);

                if (result == 2 && remainder == 0)
                {
                    Console.WriteLine("Blue: {0}, red {1}", blue, red);
                    if (blue + red > 1000000000000)
                        break;
                    //blue++;
                    //red++;

                }
                else if (result < 2)
                {
                    red++;
                }
                else if (result == 2)
                {
                    blue++;
                }
                else
                {
                    var x = "problem";
                }

                //if (blue == 100) break;

                //var ratio = (blue * (blue - 1)) / (1.0 * (blue + red) * (blue + red - 1));
                //if (ratio < 0.5)
                //{
                //    blue++; 
                //}
                //else if (ratio > 0.5)
                //{
                //    red++;
                //}
                //else if (Math.Abs(ratio - 0.5) < 0.000000001)
                //{
                //    Console.WriteLine("Blue: {0}, red {1}", blue, red);
                //    blue++;
                //    red++;
                //    if (blue + red > 1000000000000)
                //        break;
                //}
                //return blue;
            } while (true);


            return blue;
        }

     }
}
