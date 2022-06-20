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


    public class DungeonAppTests
    {

        //public class DungeonTests 
        //{
        //    [Fact]
        //    public void IncreaseScore()
        //    {
        //        int score =0;
        //        if (monster.Life <= 0)
        //        {
        //            System.Console.WriteLine();
        //        }
        //        score++;

        //        Assert.actualScoreIncrease = 1;
        //    }
        //}

        [Fact]
        public void TestHealthIncrease()
        {
            Regenerator sm4 = new Regenerator("Regenerator", 75, 1, 20, 20, 1, 2, "*This Enemy Is Not Easily Felled*", true);

            int expectedHP = 20;

            int actualHP = sm4.Life;

            Assert.Equal(expectedHP, actualHP);

        }

    //-------------------------------------- [Shadow Trooper Nighttime Test (time sensetive)] ---------------------------





    //-------------------------------------- [DarkJedi Defense Test] ---------------------------

        [Fact]
        public void TestBasDefense()
        {
            DarkJedi sm1 = new DarkJedi("Dark Jedi", 95, 10, 50, 50, 3, 15, "*A former Jedi suduced by the dark side. This one may prove challenging...*", true);

            int expectedBlock = 15;

            int actualBlock = sm1.Block;

            Assert.Equal(expectedBlock, actualBlock);

        }

    }

}