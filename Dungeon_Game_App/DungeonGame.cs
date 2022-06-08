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
            bool exit = true;
            bool exitChar = true;
            bool exitFight = true;

            Character hero = new Character("Chad Bradly", 50, 50, 9, 2);
            Weapon weapon = new Weapon("Number 2 Pencil", 1, 2, 100, false);

            //TODO create room
            

            do            
            {
                int score = 0;


                //TODO Title
                Console.Clear();
                Console.Title = "~~~~~~~~~~<( Prepare to be spooked!!)>~~~~~~~~~~";

                //Console.ForegroundColor.ConsoleColor.Green;
                Console.WriteLine(@"
  _________                     __   .__                 __    ________                                             
 /   _____/_____   ____   ____ |  | _|__| ____   _______/  |_  \______ \  __ __  ____    ____   ____  ____   ____   
 \_____  \\____ \ /  _ \ /  _ \|  |/ /  |/ __ \ /  ___/\   __\  |    |  \|  |  \/    \  / ___\_/ __ \/  _ \ /    \  
 /        \  |_> >  <_> |  <_> )    <|  \  ___/ \___ \  |  |    |    `   \  |  /   |  \/ /_/  >  ___(  <_> )   |  \ 
/_______  /   __/ \____/ \____/|__|_ \__|\___  >____  > |__|   /_______  /____/|___|  /\___  / \___  >____/|___|  / 
        \/|__|                      \/       \/     \/                 \/           \//_____/      \/           \/  ");
                Console.WriteLine("\n~~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~");








                Console.WriteLine("\n\n                                          <PRESS ANY KEY TO START> ");
                Console.ReadKey(true).Key.ToString().ToLower();//----------need proper name numb 1 different then 1----------------------- ;
                    Console.Clear();
                    //TODO boolean counter variable for main loop

                do
                {
                    //int player;
                    string playerHero;
                    Console.Clear();
                    Console.WriteLine("\n~~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~\n");
                    Console.WriteLine(" ==========<( Character Selection )>==========\n\n   <Type [c] or [v] to Choose Character> \n\n [c] [Chad Bradly] -  \"Accountant for 13 years!\" *He lost interest*\n\n [v] [Vicky Veryfast] - \"Lv 99 Rogue!\" *Looking a little light in the purse there heheh*");
                    playerHero = Console.ReadLine().ToLower();

                    switch (playerHero)
                    {
                        case "c":
                            Console.Clear();
                            Console.WriteLine("~~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~");
                            Console.WriteLine("\n *You used all your PTO and set off on your first adventure as Chad Bradly!");
                            Console.ReadKey(true);
                            exitChar = true;                           

                            break;

                        case "v":
                            Console.Clear();
                            Console.WriteLine("~~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~");
                            Console.WriteLine("\n *You decided a more practical character is in order, so you set off for glory as Vicky Veryfast!*");
                            Console.ReadKey(true);
                            exitChar = true;

                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("~~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~");
                            Console.WriteLine("\n       *Go on choose a character already!*");
                            Console.ReadKey(true);
                            exitChar = false;

                            break;
                    }
                                       
                } while (!exitChar);

                do
                {


                    Console.Clear();
                    Console.WriteLine("~~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~");
                    Console.WriteLine(GetRoom());
                    Console.ReadKey(true);
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
                            Console.WriteLine("~~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~");
                            Console.WriteLine("\n *You Attack the monster with " + "*");
                            
                            break;

                        case "2":
                            Console.WriteLine("~~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~");
                            Console.WriteLine("\n *You manage to flee from the battle*");
                            exitFight = false;

                            break;

                        case "3":
                            Console.WriteLine("~~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~");
                            Console.WriteLine("\n *You pull out your birth certificate*");

                            break;

                        case "4":
                            Console.WriteLine("~~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~");
                            Console.WriteLine("\n *You pull up the monsters perminant records. The monster looks nervous*");

                            break;

                        case "5":
                            Console.WriteLine("~~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~");
                            Console.WriteLine("\n *Thanks for playing come back soon!*");
                            Console.ReadKey(true);
                            exit = false;

                            break;



                        default:
                            Console.Clear();
                            Console.WriteLine("~~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~");
                            Console.WriteLine(" Your opponent waits patiently for you to choose an option");
                            
                            Console.ReadKey(true);
                            break;
                    }

                } while (!exitFight);


                Console.WriteLine("~~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~");

            } while (!exit);
        }//main




            //====================================================<( NOTES/ Area for Methods() >==========================================
            private static string GetRoom() //Methods cannot be on the Main()
            {
                string[] rooms = new string[] 
                {
                    "The room is dark and musty with the smell of lost souls.",
                    "You arrive in a room filled with chairs and a ticket stub machine...DMV",
                    "You enter a pretty pink powder room and instantly get glitter on you.",
                    "You enter a quiet library... silence... nothing but silence....",
                    "As you enter the room, you realize you are standing on a platform surrounded by sharks",
                    "Oh my.... what is that smell? You appear to be standing in a compost pile",
                    "You enter a dark room and all you can hear is hair band music blaring.... This is going to be bad!",
                    "Oh no.... the worst of them all... Oprah's bedroom....",
                    "The room looks just like the room you are sitting in right now... or does it?"
                };
                Random rand = new Random();

                int indexNbr = rand.Next(rooms.Length); //index #

                string room = rooms[indexNbr]; //saving value of room

                return room;    //returning the variable described in: string room = rooms[indexNbr];

                //return rooms[new Random().Next(rooms.Length)]; //This contains ALL the code from GetRoom() above just more compact. *REFACTORING*

            }//end GetRoom()

    }//class
}//namespace
