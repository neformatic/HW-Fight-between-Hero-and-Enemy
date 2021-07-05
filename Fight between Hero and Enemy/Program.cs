using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_between_Hero_and_Enemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Dev", 20, 180);
            Enemy enemy = new Enemy("Sting", 30, 160);
            while(hero.Health > 0 && enemy.Health > 0)
            {
                hero.DealDamage(enemy);
                enemy.DealDamage(hero);
            }

            if (hero.Health <= 0 && enemy.Health > 0)
            {
                Console.WriteLine($"In this fight win - {enemy.Name}");
            }
            else if (enemy.Health <= 0 && hero.Health > 0)
            {
                Console.WriteLine($"In this fight win - {hero.Name}");
            }
            else
            {
                Console.WriteLine("We have a draw!");
            }

            Console.ReadKey();
             
        }
    }
}
