using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public string SetName(string newName)
        {
            if(newName.Length > 8)
            {
                string temp=""; 
                int i = 0; 

                foreach(char c in newName)
                {
                    if(i < 8)
                    {
                        temp += c; 
                        i++; 
                    }
                }
                name = temp; 
            }
            else
            {
                name = newName; 
            }
            return name; 
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                
                if (health < 0)
                    health = 0;
            }
        }
    }
}