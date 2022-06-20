using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class DarkJedi : Monster
    {
        public bool IsPowerful { get; private set; }



        public DarkJedi(string name, int hitChance, int block, int maxLife, int life, int minDamage, int maxDamage, string description, bool isScaly) : base(
            name, hitChance, block, maxLife, life)
        {
            IsPowerful = IsPowerful;
        }

        public override string ToString()
        {
            return base.ToString() + (IsPowerful ? "*You sense the hatred in this one*" : "*This one was not fully trained*");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsPowerful)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }


        
        





    }//end class
}//end namespace
