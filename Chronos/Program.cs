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
            
            crono1.Start();

            Thread.Sleep(600);

            crono1.Stop();

            float time1 = crono1.ElapsedMilliseconds / 1000f;

            Console.WriteLine($"{time1:f3}"); 

        }
    }
}