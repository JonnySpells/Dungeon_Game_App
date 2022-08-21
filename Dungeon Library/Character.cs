namespace Dungeon_Library
{
    //ABSTRACT means it can only be inherited from; you cannot create one.
    public abstract class Character 
    {
        //========================<( Funny - Fields )>==========================================

        /*
         life - int (Completed)         
         name - string (Completed)         
         hitChance - int        
         block - int         
         maxLife - int (Completed)         
         */


        //========================<(Properties (props) )>==========================================

        private string _name;
        private int _life; //Do the same thing with MinDamage() cant exceed MaxDamage()
        private int _maxLife;
        private int _hitChance;
        private int _block;
        
        //-----------------<( Name )>------------------------
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //-----------------<( MaxLife )>---------------------
        public int MaxLife
        {
            get { return _maxLife; } //this method for homework
            set { _maxLife = value; }
            //get; set;
        }
        //Alternative shortcut, only if we don't have business rules
        //public int MaxLife {get; set;} 

        //-----------------<( Life )>------------------------
        public int Life
        {
            get { return _life; }
            set 
            {
                //Business rule: Life should not be MORE than MaxLife
                if (value <= MaxLife)
                {
                    //good to go
                    _life = value;
                }//end if
                else
                {
                    _life = MaxLife;
                }//end else
            }//end set
        }// end life prop

        //--------------------<( Block )>---------------------
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }//end Block

        public int HitChance 
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }//end HitChance

        //================================<( Collect - Constructors (ctors) )>=========================================

        //only need 1 fully qualified constructors

        public Character(string name, int hitChance, int block, int maxLife, int life)

        {
            Name = name;
            MaxLife = maxLife;
            Life = life;
            Block = block;
            HitChance = hitChance;
        }//end ctor

        public Character() { }

        //=========================================<( Monkeys Methods)>==================================================

        //ToString()
        
        public override string ToString()
        {
            //return base.ToString();
            //the default base .ToString() prints Namespace.ClassName
            return $"Profession \"{Name}\"\nHP {MaxLife}\\{Life}\n";

        }

        public virtual int CalcBlock()
        {
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0;
        }
    }
}