using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Weapon
    {
        //========================<( Funny - Fields )>========================================

        private string _name;
        private int _minDamage;
        private int _maxDamage;
        private int _bonusHitChance;
        private bool _isTwoHanded;




        //========================<( Properties )>==========================================

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public int MinDamage
        {
            get { return _minDamage; }
            set 
            {
                if (value >= MaxDamage)
                {
                    value = MaxDamage;
                }
                else
                {
                    MinDamage = MaxDamage;
                }
            } // cannot exceed max damage
        }

        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }






        //========================<( Constructor )>=======================================

        public Weapon(string name, int maxDamage, int minDamage, int bonusHitChance, bool isTwoHanded)
        {
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            
        }

        public Weapon () { }

        //========================<( Methods )>==========================================

        public override string ToString()
        {
            //return base.ToString();
            return $"Name {Name}\n" +
                   $"Two-Handed {IsTwoHanded}\n" +
                   $"Damage {MinDamage}-{MaxDamage}\n" +
                   $"Hit Bonus {BonusHitChance}\n";
        }




    }// class
}//namespace
