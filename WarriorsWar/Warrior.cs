using WarriorsWar.Enum;
namespace WarriorsWar
{
    class Warrior
    {
        private int health;
        private string name;
        private bool isAlive;

        private Weapon weapon;
        private Armor armor;

        private Faction faction;

        private int goodGuyStartHealth;
        private int badGuyStartHealth;

        //
        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

    }
}
