using System;
using System.Collections.Generic;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            int sumPoints = 0;

            List<BaseHero> heroes = new List<BaseHero>();

            

            while (heroes.Count < numberOfOperations)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                if (type == nameof(Paladin))
                {
                    BaseHero paladin = new Paladin(name);
                    heroes.Add(paladin);
                }
                else if (type == nameof(Druid))
                {
                    BaseHero druid = new Druid(name);
                    heroes.Add(druid);
                }
                else if (type == nameof(Warrior))
                {
                    BaseHero warrior = new Warrior(name);
                    heroes.Add(warrior);
                }
                else if (type == nameof(Rogue))
                {
                    BaseHero rogue = new Rogue(name);
                    heroes.Add(rogue);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }
            }

            int boosHealth = int.Parse(Console.ReadLine());

            foreach (var item in heroes)
            {
                sumPoints += item.Power;
                Console.WriteLine(item.CastAbility());
            }

            if (boosHealth > sumPoints)
            {
                Console.WriteLine("Defeat...");
            }
            else
            {
                Console.WriteLine("Victory!");
            }
        }
    }
}
