using ArenaGame.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{

    public class Sword : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Sword(string name)
        {
            Name = name;
            AttackDamage = 20;
            BlockingPower = 10;
        }

        public void WeaponAbility(Hero hero)
        {
            if(hero is Knight)
            {
                AttackDamage = 35;
                BlockingPower = 15;
            }
            else if(hero is Dwarf || hero is Assassin)
            {
                BlockingPower = 6;
            }
       
        }
    }
}
