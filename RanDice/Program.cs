using System;

namespace RanDice
{
    class Program
    {
        private static void Main(string[] args)
        {

            int n = int.Parse(args[0]);

            int s = int.Parse(args[1]);

            Random random = new Random(s);

            int diceResult = 0; 

            for(int i = 0; i < n; i++)
            {
                int randomNumber = random.Next(1, 7);

                diceResult += randomNumber;

                randomNumber = 0;  
            }
            Console.WriteLine(diceResult); 
        }
    }
}