using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Accept argument and convert srt to int
            int numberOfVillains = int.Parse(args[0]); 

            // array of enemies & accepts a number of enemies
            Enemy[] villains = new Enemy[numberOfVillains];


            // loop through enemies 
            for (int i = 0; i < villains.Length; i++)
            {
                // Request input => name of enemy
                Console.Write($"Nome do inimigo {i+1}: ");

                // store input
                string name = Console.ReadLine();

                // store info in enemy index position & create enemy
                villains[i] = new Enemy(name);

            }

            // just to print info
            foreach(Enemy enemy in villains)
            {
                Console.WriteLine
                ($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}"); 
            }
        }
    }
}
