using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_between_Hero_and_Enemy
{
    public abstract class Entity : ICharacteristics
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }

        public Entity (string name, int damage, int health)
        {
            Name = name;
            Damage = damage;
            Health = health;
        }

        public virtual void DealDamage(Entity entity)
        {
            entity.Health -= Damage;
            Console.WriteLine($"{Name} deal {Damage} damage to {entity.Name} and have - {entity.Health} points.");
        }
        
        public virtual void GetDamage()
        {

        }
    }
}
