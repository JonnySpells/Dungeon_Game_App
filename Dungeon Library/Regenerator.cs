using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Library;


namespace Dungeon_Library
{

    public class Regenerator : Monster    
    {
        public bool IsHealy { get; set; }

        public  Regenerator(string name, int hitChance, int block, int maxLife, int life, int minDamage, int maxDamage, string description, bool isHealy) : base(name, hitChance, block, maxLife, life)
        {
            IsHealy = isHealy;

            if (Life >= 15)
            {
                Life++;
            }
        }

            

    }//
}//
