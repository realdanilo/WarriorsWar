using System;
using WarriorsWar.Enum;

namespace WarriorsWar
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior("GoodLord", Faction.goodGuy);
            Warrior badGuy = new Warrior("BadLord", Faction.badGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if(rand.Next(0,10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
            }

        }
    }
}
