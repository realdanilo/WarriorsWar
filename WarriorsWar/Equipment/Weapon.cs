using WarriorsWar.Enum;

namespace WarriorsWar.Equipment
{
    class Weapon
    {
        private int damage;
        private const int good_guy_armor = 333;
        private const int bad_guy_armor = 191; 
        public int Damage
        {
            get
            {
                return damage;
            }
        }
        //ctr
        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.goodGuy:
                    damage = good_guy_armor;
                    break;
                case Faction.badGuy:
                    damage = bad_guy_armor;
                    break;
                default:
                    break;
            }

        }
    }
}