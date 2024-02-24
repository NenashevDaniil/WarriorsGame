using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersAdventures
{
   
    class Character
    {
        //Поля
        public int _health;
        public int _damage;
        public int _damage1;
        public int _defense;
        public int _newHealth;
        public int _newDamage1;
        
        

        //Конструкторы
        


        //Методы
        public void Attack()
        {
            Console.WriteLine($"Персонаж нанес {_damage} урона");

        }
        public int Remainder()
        {
            _health= _health - _newDamage1;
            return _health;
        }
        public void Hp()
        {
            Console.WriteLine($"Остаток здоровья персонажа:{_health}");
        }
        
        public int Defense()
        {
            _newDamage1 = _damage1 - _defense;
            return _newDamage1;
        }
        public void Protection ()
        {
            Console.WriteLine($"Персонаж защищается, урон уменьшается на {_defense}");
        }
        public void AddHealth()
        {
            Console.WriteLine("Введите начальное здоровье персонажа");
        }
        public void AddDefense()
        {
            Console.WriteLine("Введите защиту персонажа");
        }
        public void AddDamage()
        { Console.WriteLine("Введите урон персонажа");
            }
        public void AddDamage1()
        {
            Console.WriteLine("Введите урон противника");
        }

    }
}
