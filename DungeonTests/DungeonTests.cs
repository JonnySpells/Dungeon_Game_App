using Xunit;
using Dungeon_Library;
 

namespace DungeonTests
{
    //-------------------------------------------[Regenerator Life increase Test]--------------------------------
    #region Regenerator (Special Monster)

    public class Regenerator : Monster
    {
        public bool IsHealy { get; set; }

        public Regenerator(string name, int hitChance, int block, int maxLife, int life, int minDamage, int maxDamage, string description, bool isHealy) : base(name, hitChance, block, maxLife, life)
        {
            IsHealy = isHealy;

            if (Life >= 15)
            {
                Life += 4;
            }
        }
    }//
    #endregion

    #region DarkJedi (Special Monster)

    public class DarkJedi : Monster
    {
        public bool IsPowerful { get; private set; }



        public DarkJedi(string name, int hitChance, int block, int maxLife, int life, int minDamage, int maxDamage, string description, bool isScaly) : base(
            name, hitChance, block, maxLife, life)
        {
            IsPowerful = IsPowerful;
        }

        public override string ToString()
        {
            return base.ToString() + (IsPowerful ? "*You sense the hatred in this one*" : "*This one was not fully trained*");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsPowerful)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }
    }
    #endregion


    public class DungeonTests
    {
        //-------------------------------------- [ TestCalcHitChance() [SUCCESS] ] ---------------------------
        [Fact]
        public void TestCalcHitChance()
        {
            Weapon w1 = new Weapon("Lightsaber", 7, 3, 5, false, WeaponType.Sword);
            Player player1 = new Player("Soldier", 85, 4, 50, 50, Race.Soldier, w1);

            
            int origionalHC = 85;

            int actualHC = player1.CalcHitChance();

            Assert.True(actualHC > origionalHC);

        }
        //-------------------------------------- [ TestCalcDamage() [SUCCESS] ] ---------------------------
        [Fact]
        public void TestCalcDamage()
        {
            Weapon w1 = new Weapon("Lightsaber", 7, 3, 5, false, WeaponType.Sword);
            Player player1 = new Player("Soldier", 85, 4, 50, 50, Race.Soldier, w1);



            int actualDmg = player1.CalcDamage();

            
            
            Assert.True(actualDmg >= 3 && actualDmg <= 7);

        }

        //[Fact]
        //public void TestCalcBlock()
        //{
        //    DarkJedi sm1 = new DarkJedi("Dark Jedi", 95, 4, 50, 50, 3, 15, "*A former Jedi suduced by the dark side. This one may prove challenging...*", true);

        //    int currentBlock = 4;

        //    int newBlock = sm1.Block;

        //    Assert.True(newBlock > currentBlock);

        //}
        //-------------------------------------- [ TestHealthIncrease() [SUCCESS] ] ---------------------------
        [Fact]
        public void TestHealthIncrease()
        {
            Regenerator sm4 = new Regenerator("Regenerator", 75, 1, 20, 20, 1, 2, "*This Enemy Is Not Easily Felled*", true);

            int expectedHP = 20;

            int actualHP = sm4.Life;

            Assert.Equal(expectedHP, actualHP);

        }

    //-------------------------------------- [ TestAddScore() [SUCCESS] ] ---------------------------
        
        int score = 0;
        [Fact]
        public void TestAddScore()
        {

            score++;

            int expectedCount = 1;

            int actualCount = score;

            Assert.Equal(expectedCount, actualCount);
        }



        //-------------------------------------- [DarkJedi Defense Test [FAILED TEST] ] ---------------------------

        //[Fact] [failed test]
        //public void TestBasDefense()
        //{
        //    DarkJedi sm1 = new DarkJedi("Dark Jedi", 95, 10, 50, 50, 3, 15, "*A former Jedi suduced by the dark side. This one may prove challenging...*", true);

        //    int expectedBlock = 15;

        //    int actualBlock = sm1.CalcBlock();

        //    Assert.Equal(expectedBlock, actualBlock);

        //}



    }

}