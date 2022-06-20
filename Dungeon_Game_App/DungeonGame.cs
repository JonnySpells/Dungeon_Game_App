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
            bool leaveFight = true;

            string jedi;

            string userName;
            Player player;


            // Character hero = new Character("Chad Bradly", 50, 50, 9, 2, Race.Human, WeaponType.Melee);
            //Weapon weapon = new Weapon("Number 2 Pencil", 1, 2, 100, false, WeaponType.Melee); //add weapon type

            //TODO create room
            //int player;
            //Player player = new
            int score = 0;

            //--------------------------- WEAPON LIST ----------------------------------
            Weapon w1 = new Weapon("Lightsaber", 7, 3, 5, false, WeaponType.Sword);
            Weapon w2 = new Weapon("Force Push", 10, 5, 5, true, WeaponType.Magical);
            Weapon w3 = new Weapon("Vibro-knife", 2, 1, 10, false, WeaponType.Melee);
            Weapon w4 = new Weapon("Blaster Pistol", 6, 1, 6, true, WeaponType.Ranged);
            Weapon w5 = new Weapon("Thermal Detonator", 16, 1, 10, false, WeaponType.Explosive);
            Weapon w6 = new Weapon("Electro-Pike", 7, 1, 5, true, WeaponType.Spear);

            ////--------------------------- PLAYER OPTIONS ---------------------------------
            Player player1 = new Player("Soldier", 85, 4, 50, 50, Race.Soldier, w1);
            Player player2 = new Player("Scout", 90, 4, 31, 0, Race.Scout, w4);
            Player player3 = new Player("Scoundrel", 95, 4, 30, 30, Race.Scoundrel, w3);

            //--------------------------- MONSTERS --------------------------------







            do
            {


                Monster monster = Monster.GetMonster();

                //TODO Title
                Console.Clear();
                Console.Title = "~~~~~~~~~~<( May The Force Be With You )>~~~~~~~~~~";

                //Console.ForegroundColor.ConsoleColor.Green;
                Console.WriteLine(@"
       __   _______  _______   __            _____________             _____[]________
      |  | |   ____||       \ |  |          /_____________\=---------==|            /_________________________________
      |  | |  |__   |  .--.  ||  |         |______________| ===[O]=[]  |           ///////////////////////////////////
.--.  |  | |   __|  |  |  |  ||  |         |______________|            |           |///////////////////////////////////
|  `--'  | |  |____ |  '--'  ||  |          \_____________/=---------==|_____(0)___|-----------------------------------
 \______/  |_______||_______/ |__|         ()
                                   ");
                Console.WriteLine(@"
.___________. _______ .___  ___. .______    __       _______    .______       __    __  .__   __. 
|           ||   ____||   \/   | |   _  \  |  |     |   ____|   |   _  \     |  |  |  | |  \ |  | 
`---|  |----`|  |__   |  \  /  | |  |_)  | |  |     |  |__      |  |_)  |    |  |  |  | |   \|  | 
    |  |     |   __|  |  |\/|  | |   ___/  |  |     |   __|     |      /     |  |  |  | |  . `  | 
    |  |     |  |____ |  |  |  | |  |      |  `----.|  |____    |  |\  \----.|  `--'  | |  |\   | 
    |__|     |_______||__|  |__| |__|      |_______||_______|   |__| `._____| \______/  |__| \__| 
                                                                                                  ");
                RoseDiv();

                Console.WriteLine("\n\n\t\t\t\t\t<PRESS ANY KEY TO START>");
                Console.ReadKey(true).Key.ToString().ToLower();

                // ================================ ( Intro ) =====================================
                Console.Clear();
                RoseDiv();                                                              //MAKE IT A DREAM SEQUENCE???
                Console.WriteLine("\n\n\t*You are a former Jedi turned scavenger..*");
                Console.WriteLine("\n\n\t\t\t\t\t<PRESS ANY KEY TO PROCEED>");
                Console.ReadKey(true).Key.ToString().ToLower();

                Console.Clear();
                RoseDiv();                                                              //MAKE IT A DREAM SEQUENCE???
                Console.WriteLine("\n\n\t*Whats worse, along with your team, you were caught on a job in the former place you once called home...*");
                Console.WriteLine("\n\n\t\t\t\t\t<PRESS ANY KEY TO PROCEED>");
                Console.ReadKey(true).Key.ToString().ToLower();

                Console.Clear();
                RoseDiv();                                                              //MAKE IT A DREAM SEQUENCE???
                Console.WriteLine("\n\n\t*Currently fading in and out of consciousness. The last thing you can remember is being ambushed by\n\t\t imperials troopers inside the Temple*");
                Console.WriteLine("\n\n\t\t\t\t\t<PRESS ANY KEY TO PROCEED>");
                Console.ReadKey(true).Key.ToString().ToLower();

                Console.Clear();
                RoseDiv();                                                              //MAKE IT A DREAM SEQUENCE???
                Console.WriteLine("\n\n*You wonder who could have saved you, but as your now able to open your eyes you now see that you\n\t\t are being dragged away from the commotion by a stranger...*");
                Console.WriteLine("\n\n\t\t\t\t\t<PRESS ANY KEY TO PROCEED>");
                Console.ReadKey(true).Key.ToString().ToLower();

                Console.Clear();
                RoseDiv();
                Console.WriteLine("\n\n\t*The stanger places you next to a small tattered bonfire in a cold metal alleyway, and \n\t\tafter some rest, begins to speak*\n\n");
                Console.WriteLine("\n\n\t\t\t\t\t<PRESS ANY KEY TO PROCEED>");
                Console.ReadKey(true).Key.ToString().ToLower();

                Console.Clear();
                RoseDiv();
                Console.WriteLine("\n\n\t\"Lot of credits to be made salvaging the old Temple if you make it far enough, although\n\t\t I thought *no one* would be crazy enough to try. Not unless you were a Jedi of course.\"\n\n");
                Console.WriteLine("\n\n\t\t\t\t\t<PRESS ANY KEY TO PROCEED>");
                Console.ReadKey(true).Key.ToString().ToLower();

                Console.Clear();
                RoseDiv();
                Console.WriteLine("\n\n\t\"You wouldn't happen to be one of those jedi would you?\"\n\n\t\t\t\t\t<TYPE [Yes] or [No] TO CONTINUE>");
                jedi = Console.ReadLine().ToString().ToLower();
                Console.Clear();

                do
                {
                    switch (jedi)
                    {
                        case "y":
                        case "yes":

                            Console.Clear();
                            RoseDiv();
                            Console.WriteLine("\n\t\"No kidding. Well does this \"Jedi\" have a name?\"");
                            Console.Write("\n\tEnter your name: \n");
                            userName = Console.ReadLine();
                            Console.WriteLine("\n\t\"Steel Your Resolve {0}. Things arent as they used to be...\"", userName);
                            name = true;
                            Console.ReadKey(true).Key.ToString().ToLower();

                            break;

                        case "n":
                        case "no":

                            Console.Clear();
                            RoseDiv();
                            Console.WriteLine("\n\"Excuse me I must be mistaken then. What do they call you savenger?\"");
                            Console.Write("\nEnter your name: \n");
                            userName = Console.ReadLine(); //---------- ( USERNAME )                             
                            Console.WriteLine("\n*May the odds be with you {0}. You may need it.*", userName);
                            name = true;
                            Console.ReadKey(true).Key.ToString().ToLower();

                            break;

                        default:
                            Console.Clear();
                            RoseDiv();
                            Console.WriteLine("\n*Well Whatever You Are, You Must Have a Name Correct?*");
                            Console.Write("\nEnter your name: \n");
                            userName = Console.ReadLine();
                            Console.WriteLine("\n\"May the Force guide you {0}\"", userName);
                            name = true;
                            Console.ReadKey(true).Key.ToString().ToLower();
                            break;
                    }

                } while (!name);

                Console.WriteLine("div");

                //===========================================<( CHARACTER SELECT )>================================
                do
                {



                    Console.Clear();
                    RoseDiv();
                    Console.WriteLine("\n*As you sneak towards the secret enterence to the Temple, you reflect on \nthe life path that led you here*");
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
                            Console.WriteLine("\n\n*Stand Ready to Meet Those Who Would Do Violence Against You, and your brothers. *");
                            Console.ReadKey(true).Key.ToString().ToLower();
                            exitChar = true;

                            break;

                        case "2":
                            Console.Clear();
                            player = player2;
                            RoseDiv();
                            Console.WriteLine("\n\n*The Eyes and Ears of Your Legion, Failure Is Not An Option*");
                            Console.ReadKey(true).Key.ToString().ToLower();
                            exitChar = true;

                            break;

                        case "3":
                            Console.Clear();
                            player = player3;
                            RoseDiv();
                            Console.WriteLine("\n\n*A Life of Crime is Still Life, be wary, Scoundrel*");
                            Console.ReadKey(true).Key.ToString().ToLower();
                            exitChar = true;
                            break;

                        default:
                            Console.Clear();
                            RoseDiv();
                            Console.WriteLine("\n\n*You take a moment to clerify your thoughts*");
                            Console.ReadKey(true).Key.ToString().ToLower();
                            exitChar = false;

                            break;
                    }

                } while (!exitChar);

                Console.Clear();
                RoseDiv();
                Console.WriteLine("\nYou descend into the lesser seen catecombs of Temple. Farther, and farther you go until\n" +
                    " you reach the first area of your endeavor.");
                Console.ReadKey(true).Key.ToString().ToLower();



                //===========================================<( ENCOUNTER MENU )>==============================================




                do
                {
                    //GetMonster();
                    Console.Clear();
                    monster = Monster.GetMonster();
                    //create a room
                    Console.WriteLine(GetRoom() + $"\nA {monster.Name} appears. You ready yourself..");
                    RoseDiv();
                    Console.WriteLine("\n\nWhat would you like to do?");
                    Console.WriteLine(
                                "1] Attack\n" +
                                "2] Flee\n" +
                                "3] Player Info\n" +
                                "4] Enemy Info\n" +
                                "5] Exit");

                    string fightMenu = Console.ReadLine();
                    do
                    {

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
                                    Console.ReadKey(true).Key.ToString().ToLower();
                                    exitFight = !true;
                                }
                                else
                                {
                                    leaveFight = true;
                                }

                                break;

                            case "2":
                                Console.Clear();
                                RoseDiv();
                                //Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"\n*{monster.Name}damages you as you flee!");
                                Combat.DoAttack(monster, player);
                                Console.ReadKey(true).Key.ToString().ToLower();
                                exitFight = false;//UPDATE

                                break;

                            case "3":
                                Console.Clear();
                                RoseDiv();
                                Console.WriteLine("\n*You take a moment to collect yourself*");
                                Console.WriteLine(player);
                                Console.WriteLine("Enemies defeated: " + score);
                                Console.ReadKey(true).Key.ToString().ToLower();
                                exitFight = false;
                                leaveFight = true;

                                break;

                            case "4":
                            case "NumPad4":
                                Console.Clear();
                                RoseDiv();
                                Console.WriteLine("\n*You scan the enemy*\n\n");
                                //TODO Print monster info
                                Console.WriteLine(monster.Description);
                                Console.ReadKey(true).Key.ToString().ToLower();
                                exitFight = false;
                                leaveFight = true;

                                break;

                            case "5":

                                Console.Clear();
                                RoseDiv();
                                Console.WriteLine("\n*Thanks for playing come back soon!*");
                                Console.ReadKey(true).Key.ToString().ToLower();
                                exitFight = !false;
                                exit = !false;
                                leaveFight = !true;

                                break;



                            default:
                                Console.Clear();
                                RoseDiv();
                                Console.WriteLine("\n\tYour opponent waits patiently for you to choose an option");
                                Console.ReadKey(true).Key.ToString().ToLower();
                                exitFight = false;
                                leaveFight = true;

                                break;
                        }
                    } while (!leaveFight);

                } while (!exitFight);

                Console.WriteLine("You shouldnt see this");

                //===========================================<( EXITING GAME )>================================
            } while (!exit);

            RoseDiv();
            Console.WriteLine($"Score: {score}");


        }//main




        //====================================================<( NOTES/ Area for Methods() >==========================================

        private static void RoseDiv()
        {
            //Console.WriteLine("\n~~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~\n");
            Console.WriteLine("\n]>(==[]=======[]=======[]=======[]=======[]=======[]=======[]=======[]=======[]=======[]=======[]======[]==)<[]");
        }

        
        private static string GetRoom() //Methods cannot be on the Main()
        {
            string[] rooms = new string[] 
            {
                $"You turn the corner and stumble upon a long hallway. Theres seems to be something at the very end of it." ,
                "Out of breath from your last encounter you stop to rest by a cascading waterfall in the long forgotten Atrium." ,
                "You find yourself staring at a large locked eneterence. It feels cold to your touch... " ,
                "You enter a quiet library... silence... nothing but silence....",
                "As you enter the room, you realize there is a  ",
                "Oh my.... what is that smell? You appear to have found an abandoned trash processing area... ",
                "You enter a dark room and all you can hear is chanting.... ",
                "You stumble upon a security room. you wonder if you can find anything of use...",
                "The room looks just like the room you are sitting in right now... or does it?",
                "You hear the thunder of marching nearby! You decide its best to hide."
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
