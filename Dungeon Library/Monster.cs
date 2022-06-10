using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Monster : Character
    {
        private int _minDamage;

        public int MaxDamage { get; set; }

        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = (value > 0 && value <= MaxDamage) ? value : 1; //assigns min damage
            }
        }

        Monster m1 = new Monster("Goblin", 65, 60, 10, 10, 1, 3, "* Goblins. Nasty Little Things *");
        Monster m2 = new Monster("Swarm of Bees", 100, 60, 999, 999, 1, 2, "* Bzz Bzz Bzzzz *");
        Monster m3 = new Monster("Bandit", 100, 60, 999, 999, 1, 2, "* Doesnt look like he washed his hands.. *");
        Monster m4 = new Monster("Hollow", 100, 60, 999, 999, 1, 2, "* Bzz Bzz Bzzzz *");

        
        

        //========================================<( CONSTRUCTOR )>==========================================================
        //FQ Ctor -> pass the name, hitChance, block, maxLife, life back to the base()

        public Monster(string name, int hitChance, int block, int maxLife, int life, int minDamage, int maxDamage, string description) : base(name, hitChance, block, maxLife, life)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = description;
        }
        //override the ToString()
        public override string ToString()
        {
            return $"{Name}\n" +
                   $"Life: {Life} of {MaxLife}\n" +
                   $"Damage: {MinDamage} to {MaxDamage}\n" +
                   $"Description:\n{Description}";
        }

        //********MONSTER********
        //{Name}
        //Life: {Life} of {MaxLife}
        //Damage: {MinDamage} to {MaxDamage}        (DONE)
        //Block: {Block}
        //Description:
        //{Description}
        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(MinDamage, MaxDamage);
            return damage;
        }


        //override CalcDamage random number between min and max damage (1-15 maybe?) 1-4 2-8

        //created 4 monster subclasses. Reference Canavas instructions for more information.

        //Using room description method (GetRoom()) as a guide, create a method called GetMonster() that returns a 
        //Monster object selected randomly from a list of monsters.
        //Call this method in the main program to fight a monster. (TODO Create a monster)
        //private static string GetMonster() //Methods cannot be on the Main()
        //{
        //    string[] monsters = new string[]
        //    {


        //    };
        //    Random rand = new Random();

        //    int indexNbr = rand.Next(monsters.Length); //index #

        //    string monster = monsters[indexNbr]; //saving value of room

        //    return monster;    //returning the variable described in: string room = rooms[indexNbr];

        //    //return rooms[new Random().Next(rooms.Length)]; //This contains ALL the code from GetRoom() above just more compact. *REFACTORING*

        //}//end GetRoom()



        

        private string GetMonster() //Methods cannot be on the Main()
        {

            Monster[] monsters = new Monster[]
            {

                m1,
                m2,
                m3,
                m4


            };   

                                    
            Random rand = new Random();

            int randomNbr = rand.Next(monsters.Length);

            Monster monster = monsters[randomNbr];

            return monster;

        }//end GetRoom()

        public Dragonling()
        {
            Name = "Dragonling";
            HitChance = 25;
            Block = 20;
            MaxLife = 6;
            Life = 6;
            MinDamage = 1;
            MaxDamage = 3;
            Description = "A freshly-hatched baby dragon. It is still dangerous....";
            IsScaly = false;

           
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
