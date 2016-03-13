using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GameOfLife.Tests
{
    [TestFixture]
    public class GameOfLifeTests
    {
       
            [Test]
            public void WhenOneNeighbourIsAliveAndCellIsAliveIsDying()
            {
                Cell currentCell = new Cell() { IsAlive = true };

                bool result = RulesOfLife.WhatsNext(currentCell, 1);

                Assert.IsFalse(result);
            }
        [Test]
        public void WhenTwoNeighboursAliveAndCellIsAliveCellStaysAlive()
        {
            Cell currentCell = new Cell() { IsAlive = true };

            bool result = RulesOfLife.WhatsNext(currentCell, 2);

            Assert.IsTrue(result);
        }
        //jesli zywa i > 3 to umiera
        [Test]
        public void WhenCellIsAliveAndMoreThanThreeNeigboursIsDying()
        {
            Cell currentCell = new Cell() { IsAlive = true };

            bool result = RulesOfLife.WhatsNext(currentCell, 4);

            Assert.IsFalse(result);


        }
        //jesli sasiedzi == 3 i martwa to zywa
        [Test]
        public void WhenCellHasThreeNeighboursAndIsDeadIsAlive()
        {
            Cell currentCell = new Cell() { IsAlive = false };

            bool result = RulesOfLife.WhatsNext(currentCell, 3);

            Assert.IsTrue(result);


        }

        //komorka martwa i != 3 sasiadow to zostaje martwa
        [Test]
        public void WhenCellIsDeadAndNumberIsDifferentThanThreeCellIsDead()
        {
         


        }

    }
}
