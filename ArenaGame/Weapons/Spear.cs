using ArenaGame.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Spear : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage {get;private set; }

        public double BlockingPower {get;private set; }

        public Spear(string name)
        {
            Name = name;
            AttackDamage = 28;
            BlockingPower = 13;
        }

        public void WeaponAbility(Hero hero)
        {
            if(hero is Gladiator)
            {
                hero.Strenght += 3;
                AttackDamage = 30;
            }
            else if(hero is Dwarf)
            {
                //Dwarves have way too short hands to throw a spear properly.
                AttackDamage = 12;
            }
        }
    }
}
