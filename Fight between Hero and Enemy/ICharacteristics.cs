using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_between_Hero_and_Enemy
{
    public interface ICharacteristics
    {
        string Name { get; set; }
        int Damage { get; set; }
        int Health { get; set; }

        void DealDamage(Entity entity); // метод нанесение урона
        void GetDamage(); // метод получение урона
    }
}
