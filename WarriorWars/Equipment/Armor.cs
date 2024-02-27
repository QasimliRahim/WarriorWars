using System.Net.Http.Headers;
using WarriorWars.Enum;

namespace WarriorWars.Equipment {
    class Armor
    {
        private const int GOOD_GUY_ARMOR = 5;
        private const int BAD_GUY_ARMOR = 5;


        private int armorPoints;

        public int Armorpoints
        {
            get
            {
                return armorPoints;

            }
        }

        public Color armorColor { get; set; }

        //methdName(type ParamName, type2 ParamName2, ...)
        public Armor(Faction faction, Color color)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armorPoints = GOOD_GUY_ARMOR;
                    armorColor = Color.Green;
                    break;

                case Faction.BadGuy:
                    armorPoints = BAD_GUY_ARMOR;
                    armorColor = Color.Black;
                    break;
                default:
                    break;
            }



        }
    }
}

