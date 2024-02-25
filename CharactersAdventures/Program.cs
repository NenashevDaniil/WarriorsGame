using System;

namespace CharactersAdventures
{
    class Program
    {
        static void Main()
        {
            Character hero = new Character(100, "Hero", 15);
            Character enemy = new Character(120, "Enemy", 10);

            while (hero.Health > 0 && enemy.Health >0)
            {
               
                Console.WriteLine(hero.Attack(enemy));
                Console.WriteLine(enemy.Attack(hero));

                if (hero.Health <= 0)
                {
                    Console.WriteLine($"{enemy.Name} победил.");
                    break;
                }
                else if (enemy.Health <= 0)
                {
                    Console.WriteLine($"{hero.Name} победил.");
                    break;
                }
                else if (hero.Health <= 0 && enemy.Health <= 0)
                {
                    Console.WriteLine("Ничья");
                    break;
                }
            }
        }

    }
}
