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
        private int _damage;

        //Свойства
        public int Health { get; set; } //Автосвойство (свойство и переменная) 
        public string Name { get; set; }
        public int Damage
        {
            get
            {
                return _damage;
            }
            set
            {
                _damage = value;
            }
        }
        //Конструкторы
        public Character (int health, string name, int damage)
        {
            Name = name;
            Health = health;
            _damage = damage;
        }

        //Методы
        public string Attack(Character enemy)
        {
            Random rnd = new Random();
            if (rnd.Next(0, 2) == 0)
            {
                enemy.Health -= Damage;
            }
            else
            {
                return "Персонаж защитился от атаки.";
            }
            return $"{Name} атаковал {enemy.Name}. Теперь {enemy.Name} имеет {enemy.Health} HP.";
        }
    }
}