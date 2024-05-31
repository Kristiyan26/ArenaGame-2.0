using ArenaGame.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Axe : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get;private set; }
        public double BlockingPower { get; private set; }

        public Axe(string name)
        {
            Name = name;
            AttackDamage = 35;
            BlockingPower = 18;
        }

        public void WeaponAbility(Hero hero)
        {
           if(hero is Dwarf)
            {

                BlockingPower += 2;
                AttackDamage += 5;
            }
            else if(hero is Assassin)
            {

                AttackDamage = 15;
                BlockingPower = 9;
            }
        }
    }
}
