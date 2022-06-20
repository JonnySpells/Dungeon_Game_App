using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class ShadowTrooper : Monster
    {
        
        public DateTime NightOwl { get; set; }
           
        public bool IsPale { get; private set; }



        public ShadowTrooper(string name, int hitChance, int block, int maxLife, int life, int minDamage, int maxDamage, string description) : base(name, hitChance, block, maxLife, life)
        {

            NightOwl = DateTime.Now;
            if (NightOwl.Hour < 6 || NightOwl.Hour > 18)
            {
                HitChance += 10;
                Block += 10;
                MinDamage += 1;
                MaxDamage += 2;
            }

        }

        public override string ToString()
        {
            return String.Format("{0}\n{1}", base.ToString(), NightOwl.Hour < 6 || NightOwl.Hour > 18 ? "*It's Hungry Eyes Gleem In the Darkness...*" : "*Strike Now! At It's Hour of Frailty!*");
        }



    }//
}//
