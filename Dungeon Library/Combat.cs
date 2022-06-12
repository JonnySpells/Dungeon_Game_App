using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            int diceRoll = new Random().Next(1, 101);
            //random value between 1 - 100
            Thread.Sleep(30); //miliseconds makes next code wait until next code
            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //attack hits
                int damageDealt = attacker.CalcDamage();// for monster damage cause no weapn
                defender.Life -= damageDealt;
                Console.ForegroundColor = ConsoleColor.Red; //if hit it shows red text
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();
            }//end if attack hits
            else
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }//end ELSE (if missed)
        }//end DoAttack()

        //================================ DoBattle()
        public static void DoBattle(Player player, Monster monster)
        {
            //player attacks first
            DoAttack(player, monster);

            //monster attacks second, if they're still alive
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }//end if
        }//end DoBattle()
    }
}
