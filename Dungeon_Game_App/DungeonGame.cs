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

            // Character hero = new Character("Chad Bradly", 50, 50, 9, 2, Race.Human, WeaponType.Melee);
            //Weapon weapon = new Weapon("Number 2 Pencil", 1, 2, 100, false, WeaponType.Melee); //add weapon type

            //TODO create room
            //int player;
            string player;
            int score = 0;

            Weapon w1 = new Weapon("Falcion", 16, 2, 5, false, WeaponType.Sword);
            Weapon w2 = new Weapon("Magic Missile", 16, 2, 5, false, WeaponType.Magical);
            Weapon w3 = new Weapon("Dagger", 16, 2, 5, false, WeaponType.Melee);
            Weapon w4 = new Weapon("Short Bow", 16, 2, 5, false, WeaponType.Ranged);
            Weapon w5 = new Weapon("Cherry Bomb", 16, 2, 5, false, WeaponType.Explosive);
            Weapon w6 = new Weapon("Pike", 16, 2, 5, false, WeaponType.Spear);

            Player player1 = new Player("Soldier", 85, 4, 50, 50, Race.Soldier, w1);
            Player player2 = new Player("Scout", 90, 4, 31, 30, Race.Scout, w4);
            Player player3 = new Player("Scoundrel", 95, 4, 30, 30, Race.Scoundrel, w3);

            Monster goblin = new Monster("Goblin", 65, 60, 10, 10, 1, 3, "* Goblins. Nasty Little Things *");
            Monster bees = new Monster("Swarm of Bees", 100, 60, 999, 999, 1, 2, "* Bzz Bzz Bzzzz *");
            Monster bandit = new Monster("Bandit", 100, 60, 999, 999, 1, 2, "* Doesnt look like he washed his hands.. *");
            Monster hollow = new Monster("Hollow", 100, 60, 999, 999, 1, 2, "* Bzz Bzz Bzzzz *");
           

            Monster[] monsters = { goblin, bees, bandit, hollow, bees, bees, bees, bees, bees, bees };



            do            
            {


                //TODO Title
                Console.Clear();
                Console.Title = "~~~~~~~~~~<( Prepare to be spooked!!)>~~~~~~~~~~";

                //Console.ForegroundColor.ConsoleColor.Green;
                Console.WriteLine(@"                                                                                
# ###                              ###                                    
    /  /###  /                            ###                                   
   /  /  ###/                #             ##                             #     
  /  ##   ##                ##             ##                            ##     
 /  ###                     ##             ##                            ##     
##   ##          /###     ######## /###    ##  ##   ####      /###     ######## 
##   ##         / ###  / ######## / ###  / ##   ##    ###  / / #### / ########  
##   ##        /   ###/     ##   /   ###/  ##   ##     ###/ ##  ###/     ##     
##   ##       ##    ##      ##  ##    ##   ##   ##      ## ####          ##     
##   ##       ##    ##      ##  ##    ##   ##   ##      ##   ###         ##     
 ##  ##       ##    ##      ##  ##    ##   ##   ##      ##     ###       ##     
  ## #      / ##    ##      ##  ##    ##   ##   ##      ##       ###     ##     
   ###     /  ##    /#      ##  ##    /#   ##   ##      ##  /###  ##     ##     
    ######/    ####/ ##     ##   ####/ ##  ### / ######### / #### /      ##     
      ###       ###   ##     ##   ###   ##  ##/    #### ###   ###/        ##    
                                                         ###                    
                                                  #####   ###                   
                                                /#######  /#                    
                                               /      ###/                      ");
                RoseDiv();
                //Console.WriteLine("\n~~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~~@~@~");








                Console.WriteLine("\n\n                                          <PRESS ANY KEY TO START> ");
                Console.ReadKey(true).Key.ToString().ToLower();//----------need proper name numb 1 different then 1----------------------- ;
                    Console.Clear();
                //TODO boolean counter variable for main loop

                do
                {

                    Console.Clear();
                    RoseDiv();
                    Console.WriteLine("\n\n     *Please Choose A Class*\n\n" +
                        "[1]Soldier - Strong\n[2]Scout - Quick\n" +
                        "[3]Scoundrel - Clever\n\n   *Choose*");
                    player = Console.ReadLine();

                    switch (player)
                    {
                        case "1":
                            Console.Clear();
                            player = "Scout";
                            RoseDiv();
                            Console.WriteLine("\n\n     *You have chosen the Soldier*");
                            Console.ReadKey(true);
                            exitChar = true;

                            break;

                        case "2":
                            Console.Clear();
                            player = "Scout";
                            RoseDiv();
                            Console.WriteLine("\n\n     *You have chosen the Scout*");
                            Console.ReadKey(true);
                            exitChar = true;

                            break;

                        case "3":
                            Console.Clear();
                            player = "Scoundrel";
                            RoseDiv();
                            Console.WriteLine("\n\n     *You Have Chosen the Scoundrel*");
                            Console.ReadKey(true);
                            exitChar = true;
                            break;   

                        default:
                            Console.Clear();
                            RoseDiv();
                            Console.WriteLine("\n\n     *Pick a Character Already!*");
                            Console.ReadKey(true);
                            exitChar = false;

                            break;
                    }

                } while (!exitChar);



                //Monster[] monsters = GetMonster();
                

                

                Console.WriteLine(GetMonster());

                do
                {




                    Console.Clear();
                    RoseDiv();
                    //GetMonster();
                    Console.WriteLine(GetRoom());
                    Console.ReadKey(true);
                    Console.WriteLine(
                                "1) Attack\n" +
                                "2) Run Away\n" +
                                "3) Character Info\n" +
                                "4) Monster Info\n" +
                                "5) Exit");

                    string fightMenu = Console.ReadKey(true).Key.ToString();

                    switch (fightMenu)
                    {
                        case "1":
                        case "NumPad1":
                            RoseDiv();                          
                            Console.WriteLine($"\n *You Attack {monster.Name}!");
                            if (monster.Life <= 0)
                            {

                                Console.ForegroundColor = ConsoleColor.Green;

                                Console.WriteLine("\nYou killed {0}!\n", monster.Name);

                                Console.ResetColor();

                                score++;

                                exitFight = true;


                            }

                            break;

                        case "2":
                        case "NumPad2":
                            RoseDiv();
                            Console.WriteLine("\n *You manage to flee from {0}*");
                            exitFight = false;//UPDATE

                            break;

                        case "3":
                        case "NumPad3":
                            RoseDiv();
                            Console.WriteLine("\n *You pull out your birth certificate*");
                            Console.WriteLine(player);
                            Console.WriteLine("Monsters defeated: " + score);
                            Console.ReadKey(true);
                            exitFight = true;
                            break;

                        case "4":
                        case "NumPad4":
                            RoseDiv();
                            Console.WriteLine("\n *You pull up the monsters perminant records. The monster looks nervous*");
                            //TODO Print monster info
                            Console.WriteLine(monster.Description);
                            exitFight = true;
                            break;

                        case "5":
                        case "NumPad5":
                            RoseDiv();
                            Console.WriteLine("\n *Thanks for playing come back soon!*");
                            Console.ReadKey(true);
                            exit = false;

                            break;



                        default:
                            Console.Clear();
                            RoseDiv();
                            Console.WriteLine(" Your opponent waits patiently for you to choose an option");
                            exit = false;
                            Console.ReadKey(true);
                            break;
                    }

                } while (!exitFight);


                RoseDiv();

            } while (!exit);
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
                "You are treaversing the forrest when You encounter a " ,
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
