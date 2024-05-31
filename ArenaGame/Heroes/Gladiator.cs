using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Gladiator : Hero
    {
        private double extraAttack;
        private int hitCount;
        public Gladiator(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            hitCount = 0;
            extraAttack = 0.00;
        }

        public override double Attack()
        {
            extraAttack += 0.50;
            hitCount++;
            if (hitCount == 5)
            {
                hitCount = 0;
                extraAttack = 0.00;
            }
            return base.Attack() + extraAttack;
        }
    }
}
