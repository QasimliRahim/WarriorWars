
using System;
using System.Threading;
using WarriorWars.Enum;

namespace WarriorWars
{
    internal class EntryPoint
    {


        static Random rng = new Random();
        static void Main()
        {
            Warrior goodGuy = new Warrior("Bob", Faction.GoodGuy, Color.Green);

            Warrior badGuy = new Warrior("Joe", Faction.BadGuy, Color.Black );

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                 
                if (rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }

                Thread.Sleep(1000);
            }

            while (true)
            {
                Console.ReadLine();
            }
        }
    }
}
