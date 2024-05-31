using ArenaGame.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Crossbow : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        private int ammoCount;

        public Crossbow(string name)
        {
            Name = name;
            AttackDamage = 19;
            BlockingPower = 0;
            ammoCount = 8;
        }

        public void WeaponAbility(Hero hero)
        {
            if(hero is Dwarf)
            {
                AttackDamage = 30;
            }
            else if(hero is Gladiator)
            {
                AttackDamage = 7;
            }
            ammoCount -= 1;
            if(ammoCount == 0)
            {
                AttackDamage = 0;
                ammoCount = 8;
            }
            else
            {
                AttackDamage = 19;
            }
           
        }
    }
}
