using WarriorsWar.Enum;

namespace WarriorsWar.Equipment
{
    class Armor
    {
        private int armorPoints;
        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }
        private const int good_guy_armor = 900;
        private const int bad_guy_armor = 999;
        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.goodGuy:
                    armorPoints = good_guy_armor;
                    break;
                case Faction.badGuy:
                    armorPoints = bad_guy_armor;
                    break;
                default:
                    break;
            }

        }
    }
}