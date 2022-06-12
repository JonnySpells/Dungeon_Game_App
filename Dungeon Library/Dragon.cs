using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Dragon : Monster
    {
        public bool IsScaly { get; private set; }



        public Dragon(string name, int hitChance, int block, int maxLife, int life, int minDamage, int maxDamage, string description, bool isScaly) : base(
            name, hitChance, block, maxLife, life)
        {
            IsScaly = IsScaly;
        }

        public override string ToString()
        {
            return base.ToString() + (IsScaly ? "It's scales are strong" : "It's scales haven't matured yet");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsScaly)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }


        
        





    }//end class
}//end namespace
