using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Player : Character //inherit From Character
    {
        

        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }// CONTAINMENT 2 comlex methods

        public Player(string name, int hitChance, int block, int maxLife, int life, Race characterRace, Weapon equippedWeapon) : base(name, hitChance, block, maxLife, life)// pass back to base
        {
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            //Potential Expansion - Mosify prop values based on the chosen Race
            

        }//

        public override string ToString()
        {
            string description = "";
            switch (CharacterRace)
            {
                case Race.Soldier:
                    description = "Soldier";
                    break;
                case Race.Scout:
                    description = "Scout";
                    break;
                case Race.Scoundrel:
                    description = "Scoundral";
                    break;
 
            }//end switch
            return base.ToString() + $"\nWeapon: \n{EquippedWeapon.Name}\n" +
                $"Total Hit Chance: {CalcHitChance()}\n" +
                $"Description: {description}";
        }//end ToString();

        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }//
        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }

    }
}
