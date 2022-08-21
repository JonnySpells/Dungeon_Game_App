using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class MethodWarehouse
    {

        private static string GetRoom() //Methods cannot be on the Main()
        {
            string[] rooms = new string[]
            {
                $"You turn the corner and stumble upon a long hallway. There seems to be something at the very end of it." ,
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

            //return room;    //returning the variable described in: string room = rooms[indexNbr];

            return rooms[new Random().Next(rooms.Length)]; //This contains ALL the code from GetRoom() above just more compact. *REFACTORING*

        }//end GetRoom()


    }
}
