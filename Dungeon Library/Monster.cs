﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Monster : Character
    {
        //=============================================================<( FIELDS )>========================================================


        //none

        //===========================================================<( PROPERTIES )>===================================================
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

        
        public bool IsScaly { get; private set; }
        public bool IsStinky { get; private set; }
        public bool IsRotting { get; private set; }


        

        //Monster m1 = new Monster("Goblin", 65, 60, 10, 10, 1, 3, "* Goblins. Nasty Little Things *");
        //Monster m2 = new Monster("Swarm of Bees", 100, 60, 999, 999, 1, 2, "* Bzz Bzz Bzzzz *");
        //Monster m3 = new Monster("Bandit", 100, 60, 999, 999, 1, 2, "* Doesnt look like he washed his hands.. *");
        //Monster m4 = new Monster("Hollow", 100, 60, 999, 999, 1, 2, "* Bzz Bzz Bzzzz *");

        
        

        //========================================<( CONSTRUCTOR )>==========================================================
        //FQ Ctor -> pass the name, hitChance, block, maxLife, life back to the base()

        public Monster(string name, int hitChance, int block, int maxLife, int life, int minDamage, int maxDamage, string description) : base(name, hitChance, block, maxLife, life)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = description;
        }

        public Monster(string name, int hitChance, int block, int maxLife, int life) : base(name, hitChance, block, maxLife, life)
        {
        }

        //override the ToString()
        public override string ToString()
        {
            return $"{Name}\n" +
                   $"Life: {MaxLife} of {Life}\n" +
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

        //===================================================<( GetMonster()  )>=======================================


        //Using room description method (GetRoom()) as a guide, create a method called GetMonster() that returns a 
        //Monster object selected randomly from a list of monsters.
        //Call this method in the main program to fight a monster. (TODO Create a monster)

        public static Monster GetMonster() //Methods cannot be on the Main()
        {
            Monster m1 = new Monster("Storm Trooper", 65, 1, 10, 10, 1, 3, "* Goblins. Nasty Little Things *");
            Monster m2 = new Monster(" ", 100, 50, 100, 100, 1, 2, "* An You find plunder in the Empty room*");
            Monster m3 = new Monster("Bandit", 75, 60, 1, 15, 2, 5, "* Doesnt look like he washed his hands.. *");
            Monster m4 = new Monster("Hollow", 60, 0, 10, 10, 1, 5, "* Hollow Men. Do Not Feel Pitty For Them *");
            Dragon sm1 = new Dragon("Dragon", 95, 5, 50, 50, 3, 15, "*Yes. Swooping is bad..*", true);
            Dragon sm2 = new Dragon("Dragonling", 95, 5, 50, 50, 3, 15, "*Joey Lost his dragon*", false);
            Vampire sm3 = new Vampire("Shadow Trooper", 85, 2, 35, 20, 3, 10, "*An apex predator of the night*");
            Regenerator sm4 = new Regenerator("Regenerator", 75, 1, 20, 20, 1, 2, "*This Enemy Is Not Easily Felled*", true);



            Monster[] monsters = { m1, m2, m3, m4, sm1, sm2, sm3, sm4};
            
            

            Random rand = new Random();

            int indexNbr = rand.Next(monsters.Length); //index #

            Monster monster = monsters[indexNbr]; //saving value of room

            return monster;    //returning the variable described in: string monster = monsters[indexNbr];
        

        }//end GetMonster()

        //======================================= CaclBlock() =====================================================





        //============================================<( Unique Monsters )>=======================================================

    //    public Dragon() 
    //    {
    //        Name = "Dragon";
    //        HitChance = 25;
    //        Block = 20;
    //        MaxLife = 6;
    //        Life = 6;
    //        MinDamage = 1;
    //        MaxDamage = 3;
    //        Description = "What is it? Dragons?";
    //        IsScaly = true;
    //    }

    //    public Dragonling()
    //    {
    //        Name = "Dragonling";
    //        HitChance = 25;
    //        Block = 20;
    //        MaxLife = 6;
    //        Life = 6;
    //        MinDamage = 1;
    //        MaxDamage = 3;
    //        Description = "A freshly-hatched baby dragon. It is still dangerous....";
    //        IsScaly = false;


    //    }




    //    public Zombie()
    //    {
    //        Name = "Zamboh";
    //        HitChance = 25;
    //        Block = 1;
    //        MaxLife = 2;
    //        Life = 2;
    //        MinDamage = 2;
    //        MaxDamage = 30;
    //        Description = "Can't wait to sink it's teeth into you";
    //        IsRotting = true;
    //    }

    //    public Dragon()
    //    {
    //    Name = "Braff Zachland";
    //    HitChance = 100;
    //    Block = 20;
    //    MaxLife = 900;
    //    Life = 900;
    //    MinDamage = 20;
    //    MaxDamage = 30;
    //    Description = "No. I dont want a sample.";
    //    IsStinky = true;
    //}




}//end class
}//end namespace
