using System;
using System.Diagnostics;

// must use thread
using System.Threading; 

namespace Chronos
{
    class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch(); 
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();

            Thread.Sleep(600);

            crono2.Start(); 

            Thread.Sleep(200);

            crono1.Stop();
            crono2.Stop();

            float time1 = crono1.ElapsedMilliseconds / 1000f;
            float time2 = crono2.ElapsedMilliseconds / 1000f;

            Console.WriteLine($"{time1:f3}"); 

            Console.WriteLine($"{time2:f3}"); 

        }
    }
}