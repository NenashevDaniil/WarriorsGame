using System;

namespace CharactersAdventures
{
    class Program
    {


        static void Main()

            
        {
            
            Character character= new Character();
            character.AddHealth();
            character._health = Convert.ToInt32(Console.ReadLine());
            character.AddDamage();
            character._damage = Convert.ToInt32(Console.ReadLine());
            character.AddDefense();
            character._defense = Convert.ToInt32(Console.ReadLine());
            character.AddDamage1();
            character._damage1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Enemy enemy = new Enemy();
            enemy.AddHealth();
            enemy._health1 = Convert.ToInt32(Console.ReadLine());
            enemy.AddDamage1();
            enemy._damage1 = Convert.ToInt32(Console.ReadLine());
            enemy.AddDefense();
            enemy._defense1 = Convert.ToInt32(Console.ReadLine());
            enemy.AddDamage();
            enemy._damage = Convert.ToInt32(Console.ReadLine());

            while  (character._health > 0 & enemy._health1 > 0)  
            {



                character.Attack();
                enemy.Defense();
                enemy.Remainder();
                enemy.Hp();
                if (enemy._health1 <= 0)
                {
                    Console.WriteLine($"персонаж победил");
                    continue;
                }

                else
                    Console.WriteLine();

                enemy.Attack();
                character.Defense();
                character.Remainder();
                character.Hp();
                if (character._health <= 0)
                {
                    Console.WriteLine($"противник победил");
                    continue;
                }

                else
                    Console.WriteLine();


            }
            





        }

    }
}
