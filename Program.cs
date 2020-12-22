using System;
using System.Diagnostics;

namespace Memory
{
    class Program
    {
        static void Main(string[] args)
            {
                int[][] AD = new int[2][];
                AD[0] = new int[2];
                AD[1] = new int[2];
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                for (int j = 500000000; j > 0; j--)
                {
                    AD[0][0]++;
                    AD[0][0]++;
                    //AD[1][1]+=2;
                }

            AD[1][1] = AD[0][0];
            stopWatch.Stop();

            Console.WriteLine(AD[1][1]); 
                
                Console.WriteLine("RunTime: " + Math.Round(stopWatch.Elapsed.TotalMilliseconds));
            
            }
       
    }
}
