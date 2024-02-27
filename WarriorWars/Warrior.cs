using System;
using WarriorWars.Enum;
using WarriorWars.Equipment;
namespace WarriorWars

{
    internal class Warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 20;
        private  const int BAD_GUY_STARTING_HEALTH= 20;
         


        private readonly Faction faction;
        private int health;
        private string name;
        private readonly Faction Faction;
        private bool isAlive;


        public bool IsAlive {
            get
            {
                return isAlive;
            }
        }

        private Weapen weapen;
        private Armor armor;
        private Color color;

        public Warrior(string name, Faction faction, Color color)
        {
            this.name = name;
            Faction = faction;
            isAlive = true;
            this.color = color;


            switch (faction)
            {
                case Faction.GoodGuy:
                    weapen = new Weapen(faction);
                    armor = new Armor(faction, Color.Green);
                    

                    health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BadGuy:
                    weapen = new Weapen(faction);
                    armor = new Armor(faction, Color.Black);
                    health = BAD_GUY_STARTING_HEALTH; 
                    break;
                default:
                    break;



            }
        }

        public void Attack(Warrior enemy)
        {
            int damage = weapen.Damage / enemy.armor.Armorpoints;
            enemy.health -= damage;

            AttackResult(enemy, damage);
        }

        public void AttackResult(Warrior enemy, int damage)
        {
         
            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                Tools.ColorfulWriteLine($"{enemy.name} is dead!", ConsoleColor.Red);
                Tools.ColorfulWriteLine($"{name} is victorious!", ConsoleColor.Green);
            }
            else
            {
                Console.WriteLine($"{name} attacked {enemy.name}. {damage} damage was infilcted to {enemy.name} remaining health is { enemy.health}");
            }
        }

    }
}
