using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Dwarf : Hero
    {
        private int hitCount;
        public Dwarf(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            hitCount= 0;
        }

        public override double Defend(double damage)
        {
            hitCount++;
            if(hitCount == 3)
            {
                hitCount = 0;
                return base.Defend(damage/2);
            }
            else
            {
                return base.Defend(damage);
            }
           

        }
    }
}
