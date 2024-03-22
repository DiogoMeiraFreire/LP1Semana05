using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfVillains = int.Parse(args[0]); 

            Enemy[] villains = new Enemy[numberOfVillains];


            for (int i = 0; i < villains.Length; i++)
            {
                Console.Write($"Nome do inimigo {i+1}: ");

                string name = Console.ReadLine();

                villains[i] = new Enemy(name);

            }

            foreach(Enemy enemy in villains)
            {
                Console.WriteLine
                ($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}"); 
            }

            villains[0].TakeDamage(60);

            villains[0].PickupPowerUp(PowerUp.Health, 10);

            villains[0].PickupPowerUp(PowerUp.Shield, 15);

            villains[0].PickupPowerUp(PowerUp.Health, 10);


            if(villains.Length > 1)
            {
                villains[1].TakeDamage(60);

                villains[1].PickupPowerUp(PowerUp.Shield, 15);

            }

            
            for(int i = 0; i < villains.Length; i++)
            {
                Console.WriteLine
                ($"{villains[i].GetName()} {villains[i].GetHealth()}"
                + $" {villains[i].GetShield()} {Enemy.GetPowerUpsCollected()}"); 
            }
        }
    }
}
