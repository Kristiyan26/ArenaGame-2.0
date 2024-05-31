using ArenaGame.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Dagger : IWeapon
    {
        private int hitCount;
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Dagger(string name)
        {
            Name = name;
            AttackDamage = 26;
            BlockingPower = 1;
            hitCount = 0;
        }

        public void WeaponAbility(Hero hero)
        {
            hitCount++;
           if(hero is Assassin)
            {
                hero.Strenght *= 1.2;
                Random random = new Random();
                double randomNum = random.NextDouble();
                if(randomNum >= 0.80)
                {
                    this.AttackDamage *= 2;
                }
                else if(randomNum >= 0.50)
                {
                    this.AttackDamage += 15;
                }
                else
                {
                    this.AttackDamage += 8;
                }
                
            }
           else if(hero is Gladiator)
            {
                AttackDamage = 14;
            }

            if(hitCount == 7)
            {
                AttackDamage *= 2;
            }
        }
    }
}
