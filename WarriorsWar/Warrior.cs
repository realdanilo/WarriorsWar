using WarriorsWar.Enum;
using WarriorsWar.Equipment;
namespace WarriorsWar
{
    class Warrior
    {
        private int health;
        private string name;
        private bool isAlive;

        private Weapon weapon;
        private Armor armor;

        //set once, can not be changed later
        private readonly Faction FACTION;

        //const, no one will be able to change 
        private const int good_Guy_Start_Health = 100;
        private const int bad_Guy_Start_Health = 300;

        //
        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        //constructor
        public Warrior(string name, Faction faction)
        {
            this.name = name;
            this.FACTION = faction;
            isAlive = true;

            switch (this.FACTION)
            {
                case Faction.goodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = good_Guy_Start_Health;
                    break;
                case Faction.badGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = bad_Guy_Start_Health;
                    break;
                default:
                    break;
            }
        }
        //attack
        
    }
}
