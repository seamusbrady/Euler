using System;
using System.Diagnostics;

namespace Euler
{
static class Program
{
    static void Main(string[] args)
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        var result = new Problem043().Run();
        stopWatch.Stop();

        Console.WriteLine("solution = {0}\nTime: {1}", result, stopWatch.ElapsedMilliseconds);
        Console.ReadLine();
    }
}
}
