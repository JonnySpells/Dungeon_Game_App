
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Weapon 
    {
        //=========================================<( Funny - Fields )>============================================

        private string _name;
        private int _minDamage;
        private int _maxDamage;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private WeaponType _type;



        //===========================================<( Properties )>===============================================
        

        //-----------------------( Name )-------------------------
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //---------------------( MaxDamage )----------------------
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        //-----------------------( MinDamage )--------------------
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
        //-----------------------( BonusHitChance )----------------
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        //-----------------------( IsTwoHanded )-------------------
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }
        //-----------------------( Weapon Type )-------------------  
        public WeaponType Type
        {
            get { return _type; }
            set { _type = value; }
        }






        //===========================================<( Constructor )>==================================================

        //------------<( Fully Qualified Ctor)>----------
        public Weapon(string name, int maxDamage, int minDamage, int bonusHitChance, bool isTwoHanded, WeaponType type)
        {
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Type = Type;
            
        }

        public Weapon () { }

        //========================<( Methods )>==========================================

        public override string ToString()
        {
            //return base.ToString();
            return $"Name {Name}\n" +
                   $"Type {Type}\n" +
                   $"Two-Handed {IsTwoHanded}\n" +
                   $"Damage {MinDamage}-{MaxDamage}\n" +
                   $"Hit Bonus {BonusHitChance}\n";
        }




    }// class
}//namespace
