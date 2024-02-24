using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersAdventures
{
    class Enemy
    {
        public int _health1;
        public int _damage1;
        public int _damage;
        public int _defense1;
        public int _newHealth1;
        public int _newDamage;
        public void Attack()
        {
            Console.WriteLine($"Противник нанес {_damage1} урона");

        }
        public int Remainder()
        {
            _health1 = _health1 - _newDamage;
            return _health1;
        }
        public void Hp()
        {
            Console.WriteLine($"Остаток здоровья противника:{_health1}");
        }

        public int Defense()
        { 
            _newDamage = _damage - _defense1;
            return _newDamage;
        }
        public void Protection()
        {
            Console.WriteLine($"Персонаж защищается, урон уменьшается на {_defense1}");
        }
        public void AddHealth()
        {
            Console.WriteLine("Введите начальное здоровье противника");
        }
        public void AddDefense()
        {
            Console.WriteLine("Введите защиту противника");
        }
        public void AddDamage1()
        {
            Console.WriteLine("Введите урон противника");
        }
        public void AddDamage()
        {
            Console.WriteLine("Введите урон персонажа");
        }
    }
}

