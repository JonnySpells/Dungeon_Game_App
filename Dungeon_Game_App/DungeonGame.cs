using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Library;

namespace Dungeon_Game_App
{
    internal class DungeonGame
    {
        static void Main(string[] args)
        {
            bool name = true;
            bool exit = true;
            bool exitChar = true;
            bool exitFight = true;

            string merc;
            string userName;
            Player player;
                
            

            // Character hero = new Character("Chad Bradly", 50, 50, 9, 2, Race.Human, WeaponType.Melee);
            //Weapon weapon = new Weapon("Number 2 Pencil", 1, 2, 100, false, WeaponType.Melee); //add weapon type

            //TODO create room
            //int player;
            //Player player = new
            int score = 0;

            //--------------------------- WEAPON LIST ----------------------------------
            Weapon w1 = new Weapon("Falcion", 6, 1, 5, false, WeaponType.Sword);
            Weapon w2 = new Weapon("Magic Missile", 12, 2, 5, true, WeaponType.Magical);
            Weapon w3 = new Weapon("Dagger", 4, 1, 10, false, WeaponType.Melee);
            Weapon w4 = new Weapon("Short Bow", 6, 1, 5, true, WeaponType.Ranged);
            Weapon w5 = new Weapon("Cherry Bomb", 16, 2,2, false, WeaponType.Explosive);
            Weapon w6 = new Weapon("Pike", 10, 1, 5, true, WeaponType.Spear);

            ////--------------------------- PLAYER OPTIONS ---------------------------------
            Player player1 = new Player("Soldier", 85, 4, 50, 50, Race.Soldier, w1);
            Player player2 = new Player("Scout", 90, 4, 31, 30, Race.Scout, w4);
            Player player3 = new Player("Scoundrel", 95, 4, 30, 30, Race.Scoundrel, w3);

            //--------------------------- MONSTERS --------------------------------
            
           

            



            do            
            {

                Monster monster = Monster.GetMonster();

                //TODO Title
                Console.Clear();
                Console.Title = "~~~~~~~~~~<( Prepare to be spooked!!)>~~~~~~~~~~";

                //Console.ForegroundColor.ConsoleColor.Green;
                Console.WriteLine(@"
 ,--.--------.    ,----.    ,-,--.  ,--.--------.         ,--.--------.  .=-.-.,--.--------.               ,----.  
/==/,  -   , -\,-.--` , \ ,-.'-  _\/==/,  -   , -\       /==/,  -   , -\/==/_ /==/,  -   , -\  _.-.     ,-.--` , \ 
\==\.-.  - ,-./==|-  _.-`/==/_ ,_.'\==\.-.  - ,-./       \==\.-.  - ,-./==|, |\==\.-.  - ,-./.-,.'|    |==|-  _.-` 
 `--`\==\- \  |==|   `.-.\==\  \    `--`\==\- \           `--`\==\- \  |==|  | `--`\==\- \  |==|, |    |==|   `.-. 
      \==\_ \/==/_ ,    / \==\ -\        \==\_ \               \==\_ \ |==|- |      \==\_ \ |==|- |   /==/_ ,    / 
      |==|- ||==|    .-'  _\==\ ,\       |==|- |               |==|- | |==| ,|      |==|- | |==|, |   |==|    .-'  
      |==|, ||==|_  ,`-._/==/\/ _ |      |==|, |               |==|, | |==|- |      |==|, | |==|- `-._|==|_  ,`-._ 
      /==/ -//==/ ,     /\==\ - , /      /==/ -/               /==/ -/ /==/. /      /==/ -/ /==/ - , ,/==/ ,     / 
      `--`--``--`-----``  `--`---'       `--`--`               `--`--` `--`-`       `--`--` `--`-----'`--`-----``  ");
                RoseDiv();
                
                Console.WriteLine("\n\n\t<PRESS ANY KEY TO START> ");
                Console.ReadKey(true).Key.ToString().ToLower();

                // ================================ ( Intro ) =====================================
                Console.Clear();
                RoseDiv();
                Console.WriteLine("*Yet Another Mercinary Come to Find Riches*");
                Console.ReadKey(true).Key.ToString().ToLower();

                Console.Clear();
                RoseDiv();
                Console.WriteLine("*You are a mercinary are you not?..*\n[Yes] or [No]");
                merc = Console.ReadLine().ToLower();
                Console.Clear();






                do
                {
                    switch (merc)
                    {
                        case "y":
                        case "yes":

                            Console.Clear();
                            RoseDiv();
                            Console.WriteLine("\n*Well Does this \"Does this mercinary\" have a name?*");                            
                            Console.Write("\nEnter your name: \n");
                            userName = Console.ReadLine();
                            Console.WriteLine("\n*Steel Your Resolve {0} the mercinary or Fall With the Rest of the Common Rabble*", userName);
                            name = true;
                            Console.ReadKey();

                            break;

                        case "n":
                        case "no":

                            Console.Clear();
                            RoseDiv();
                            Console.WriteLine("\n*Excuse Me I Must Be Mistaken Then. What Are You Called Commoner?*");                            
                            Console.Write("\nEnter your name: \n");
                            userName = Console.ReadLine(); //---------- ( USERNAME )                             
                            Console.WriteLine("\n*May Your Gods Are With You {0} the Commoner.*", userName);
                            name = true;
                            Console.ReadKey();

                            break;                        

                        default:
                            Console.Clear();
                            RoseDiv();
                            Console.WriteLine("\n*Well Whatever You Are, You Must Have a Name Correct?*");
                            Console.Write("\nEnter your name: \n");
                            userName = Console.ReadLine();
                            Console.WriteLine("\n*May The Wind Be At Your Back {0}*", userName);
                            name = true;
                            Console.ReadKey();
                            break;
                    }

                } while (!name);

                Console.WriteLine("div");

                //===========================================<( CHARACTER SELECT )>================================
                do
                {



                    Console.Clear();
                    RoseDiv();
                    Console.WriteLine("\n*As You Step Towards The Enterence Towards the Dungeon You Reflect On Why You Are Here*");
                    Console.WriteLine("\n\nPlease Select Profession\n\n" +
                        "[1]Soldier - Strong, and Resilient\n[2]Scout - Moderate, and Efficient\n" +
                        "[3]Scoundrel - Quick, and Clever\n\n   *Choose*");
                    string userChoice = Console.ReadLine();
                    player = player1;
                    switch (userChoice)
                    {
                        case "1":
                            Console.Clear();
                            player = player1;
                            RoseDiv();
                            Console.WriteLine("\n\n*Stand Ready to Meet Those Who Would Do Violence Against You, And Your Brothers*");
                            Console.ReadKey(true);
                            exitChar = true;

                            break;

                        case "2":
                            Console.Clear();
                            player = player2;
                            RoseDiv();
                            Console.WriteLine("\n\n*The Eyes and Ears of Your Legion, Failure Is Not An Option*");
                            Console.ReadKey(true);
                            exitChar = true;

                            break;

                        case "3":
                            Console.Clear();
                            player = player3;
                            RoseDiv();
                            Console.WriteLine("\n\n*A Life of Crime is Still Life, Be Wary, Scoundral*");
                            Console.ReadKey(true);
                            exitChar = true;
                            break;   

                        default:
                            Console.Clear();
                            RoseDiv();
                            Console.WriteLine("\n\n*Dont Be Shy*");
                            Console.ReadKey(true);
                            exitChar = false;

                            break;
                    }

                } while (!exitChar);

                Console.Clear();
                RoseDiv();
                Console.WriteLine("\nEntering Dungeon Prepare To Be SPOOKED!!!");
                Console.ReadKey(true);



                //===========================================<( ENCOUNTER MENU )>==============================================



                do
                {

                    //GetMonster();
                    Console.Clear();
                    monster = Monster.GetMonster();
                    //create a room
                    Console.WriteLine(GetRoom() + $"\nIn this room: {monster.Name}");
                    RoseDiv();                                    
                    Console.WriteLine("\n\nWhat would you like to do?");
                    Console.WriteLine(
                                "1) Attack\n" +
                                "2) Run Away\n" +
                                "3) Character Info\n" +
                                "4) Monster Info\n" +
                                "5) Exit");

                    string fightMenu = Console.ReadLine();

                    switch (fightMenu)
                    {
                        case "1":
                            Console.Clear();
                            RoseDiv();                          
                            Console.WriteLine($"\n*You Attack {monster.Name} with a flurry of blows!\n");
                            if (monster.Life <= 0)
                            {
                                Console.Clear();
                                RoseDiv();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou killed {0}!\n", monster.Name);
                                Console.ResetColor();

                                score++;
                                Console.ReadKey();
                                exitFight = !true;
                            }

                            break;

                        case "2":
                            Console.Clear();
                            RoseDiv();
                            Console.WriteLine($"\n*{monster.Name}attacks you as you flee!");
                            Combat.DoAttack(monster, player);
                            Console.ReadKey(true);
                            exitFight = false;//UPDATE

                            break;

                        case "3":
                            Console.Clear();
                            RoseDiv();
                            Console.WriteLine("\n*You pull out your birth certificate*");
                            Console.WriteLine(player);
                            Console.WriteLine("Monsters defeated: " + score);
                            Console.ReadKey(true);
                            exitFight = !true;
                            break;

                        case "4":
                        case "NumPad4":
                            Console.Clear();
                            RoseDiv();
                            Console.WriteLine("\n*You pull up the monsters perminant records. The monster looks nervous*\n\n");
                            //TODO Print monster info
                            Console.WriteLine(monster.Description);
                            Console.ReadKey(true);
                            exitFight = false;
                            break;

                        case "5":

                            Console.Clear();
                            RoseDiv();
                            Console.WriteLine("\n*Thanks for playing come back soon!*");
                            Console.ReadKey(true);
                            exitFight = !false;
                            exit = !false;

                            break;



                        default:
                            Console.Clear();
                            RoseDiv();
                            Console.WriteLine("\n\tYour opponent waits patiently for you to choose an option");
                            Console.ReadKey(true);
                            exit = !true;

                            break;
                    }

                } while (!exitFight);

                Console.WriteLine("You shouldnt see this");
                
                //===========================================<( EXITING GAME )>================================
            } while (!exit);

            RoseDiv();
            Console.WriteLine("display score");


        }//main




            //====================================================<( NOTES/ Area for Methods() >==========================================
           
        private static void RoseDiv()
        {
            Console.WriteLine("\n~~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~\n");
        }
        
        private static string GetRoom() //Methods cannot be on the Main()
        {
            string[] rooms = new string[] 
            {
                $"You take a step into a quite long halloway. Theres seems to be something at the veryy end of it. " ,
                "Out of breath from your last encounter you stop to rest by a cascading waterfall. You decide to " ,
                "You enter a pretty pink powder room and instantly get glitter on you. " ,
                "You enter a quiet library... silence... nothing but silence....",
                "As you enter the room, you realize you are standing on a platform surrounded by sharks ",
                "Oh my.... what is that smell? You appear to be standing in a compost pile ",
                "You enter a dark room and all you can hear is hair band music blaring.... This is going to be bad! ",
                "Oh no.... the worst of them all... Oprah's bedroom....",
                "The room looks just like the room you are sitting in right now... or does it?"
            };
            Random rand = new Random();

            int indexNbr = rand.Next(rooms.Length); //index #

            string room = rooms[indexNbr]; //saving value of room

            return room;    //returning the variable described in: string room = rooms[indexNbr];

            return rooms[new Random().Next(rooms.Length)]; //This contains ALL the code from GetRoom() above just more compact. *REFACTORING*

        }//end GetRoom()


               
        
        //Monster[] monsters = new GetMonster();

            //int indexNbr = rand.Next(monsters.Length); 

            //string monster = monsters[indexNbr]; 

            //return ;   

           


    }//class
}//namespace
