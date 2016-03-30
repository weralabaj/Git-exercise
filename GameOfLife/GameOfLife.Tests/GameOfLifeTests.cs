using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
/*

    pierwsze testy wykonałem za pomocą unit testów, później spróbowałem wykorzystać test case'y

*/
namespace GameOfLife.Tests
{
    [TestFixture]
    public class GameOfLifeTests
    {
        public bool testCaseResult;
        //1.Każda komórka, posiadająca mniej niż dwóch żywych sąsiadów umiera
        [Test]
        public void WhenCellIsAliveAndHasLessThanTwoAliveNeighboursIsDead()
        {
            Cell currentCell = new Cell() {IsAlive = true};
            bool result = RulesOfLife.WhatsNext(currentCell, 0);
            Assert.IsFalse(result);
            //podobno nie powinno się dwóch asercji w jednym teście przeprowadzać
            bool result1 = RulesOfLife.WhatsNext(currentCell, 1);
            Assert.IsFalse(result1);
        }
        //2.Każda komórka, która posiada dwóch lub trzech żywych sąsiadów przeżywa
        [Test]
        public void WhenCellHasTwoOrThreeAliveNeighboursIsAlive()
        {
            Cell currentCell = new Cell() { IsAlive = true };
            bool result = RulesOfLife.WhatsNext(currentCell, 2);
            Assert.IsTrue(result);
            bool result1 = RulesOfLife.WhatsNext(currentCell, 3);
            Assert.IsTrue(result1);

        }
        //3.Każda komórka posiadająca więcej niż trzech żywych sąsiadów umiera
        [Test]
        public void WhenCellHasMoreThanThreeAliveNeighboursIsDead()
        {
            Cell currentCell = new Cell() { IsAlive = true };
            bool result = RulesOfLife.WhatsNext(currentCell, 4);
            Assert.IsFalse(result);
        }
        //4.Komórka będąca oznaczona jako martwa a posiadająca dokładnie trzech sąsiadów staje się komórką żywą
        [Test]
        public void WhenCellIsDeadAndHasExactlyThreeAliveNeighboursIsAlive()
        {
            Cell currentCell = new Cell() {IsAlive = false};
            bool result = RulesOfLife.WhatsNext(currentCell, 3);
            Assert.IsTrue(result);
        }
        //komórka martwa i != 3 sąsiadów to zostaje martwa
        [Test]
        public void WhenCellIsDeadAndNumberOfNeighboursIsDifferentThanThreeIsDead()
        {
            Cell currentCell = new Cell() { IsAlive = false };
            bool result = RulesOfLife.WhatsNext(currentCell, 1);
            Assert.IsFalse(result);

        }
        //komórka żywa i jeden sąsiad
        [Test]
            public void WhenOneNeighbourIsAliveAndCellIsAliveIsDead()
            {
                Cell currentCell = new Cell() { IsAlive = true };
                bool result = RulesOfLife.WhatsNext(currentCell, 1);
                Assert.IsFalse(result);
            }
        //komórka żywa i ma dwóch sąsiadów pozostaje żywa
        [Test]
        public void WhenTwoNeighboursAreAliveAndCellIsAliveStayAlive()
        {
            Cell currentCell = new Cell() { IsAlive = true };
            bool result = RulesOfLife.WhatsNext(currentCell, 2);
            Assert.IsTrue(result);
        }
        //komórka żywa i ma więcej niż trzech sąsiadów umiera
        [Test]
        public void WhenCellIsAliveAndHasMoreThanThreeNeighboursIsDead()
        {
            Cell currentCell = new Cell() { IsAlive = true };
            bool result = RulesOfLife.WhatsNext(currentCell, 4);
            Assert.IsFalse(result);

        }
        //jeśli komórka jest martwa a liczba sąsiadów wynosi 3 to ożywa
        [Test]
        public void WhenCellHasThreeNeighboursAndIsDeadBecomeAlive()
        {
            Cell currentCell = new Cell() { IsAlive = false };
            bool result = RulesOfLife.WhatsNext(currentCell, 3);
            Assert.IsTrue(result);


        }

        //Test case'y
        //1.Każda komórka, posiadająca mniej niż dwóch żywych sąsiadów umiera
        [TestCase(0)]
        [TestCase(1)]
        public void WhenCellIsAliveAndHasLessThanTwoAliveNeighboursIsDeadTestCase(int aliveNeighbours)
        {
            Cell currentCell = new Cell() { IsAlive = true };
            bool result = RulesOfLife.WhatsNext(currentCell, aliveNeighbours);
            Assert.IsFalse(result);
           
        }
        //2.Każda komórka, która posiada dwóch lub trzech żywych sąsiadów przeżywa
        [TestCase(2)]
        [TestCase(3)]
        public void WhenCellHasTwoOrThreeAliveNeighboursIsAliveTestCase(int aliveNeighbours)
        {
            Cell currentCell = new Cell() { IsAlive = true };
            bool result = RulesOfLife.WhatsNext(currentCell, aliveNeighbours);
            Assert.IsTrue(result);
            bool result1 = RulesOfLife.WhatsNext(currentCell, aliveNeighbours);
            Assert.IsTrue(result1);

        }
        //3.Każda komórka posiadająca więcej niż trzech żywych sąsiadów umiera
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        public void WhenCellHasMoreThanThreeAliveNeighboursIsDeadTestCase(int aliveNeighbours)
        {
            Cell currentCell = new Cell() { IsAlive = true };
            bool result = RulesOfLife.WhatsNext(currentCell, 4);
            Assert.IsFalse(result);
        }
        //4.Komórka będąca oznaczona jako martwa a posiadająca dokładnie trzech sąsiadów staje się komórką żywą
        [TestCase(3)]
        public void WhenCellIsDeadAndHasExactlyThreeAliveNeighboursIsAliveTestCase(int aliveNeighbours)
        {
            Cell currentCell = new Cell() { IsAlive = false };
            bool result = RulesOfLife.WhatsNext(currentCell, 3);
            Assert.IsTrue(result);
        }
        //komórka martwa i liczba sąsiadów jest różna niż 3 to pozostaje martwa
        [TestCase(6)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        public void WhenCellIsDeadAndNumberOfNeighboursIsDifferentThanThreeIsDeadTestCase(int aliveNeighbours)
        {
            Cell currentCell = new Cell() { IsAlive = false };
            bool result = RulesOfLife.WhatsNext(currentCell, 1);
            Assert.IsFalse(result);
            
        }
        //test case z nazwanym parametrem
        //komórka żywa i jeden sąsiad to komórka umiera
        [TestCase(1),]
        public void WhenOneNeighbourIsAliveAndCellIsAliveIsDeadTestCase(int aliveNeighbours)
        {
            Cell currentCell = new Cell() { IsAlive = true };
            bool result = RulesOfLife.WhatsNext(currentCell, 1);
            Assert.IsFalse(result);
        }
        //komórka żywa i ma dwóch sąsiadów pozostaje żywa
        [TestCase(2)]
        public void WhenTwoNeighboursAreAliveAndCellIsAliveStayAliveTestCase(int aliveNeighbours)
        {
            Cell currentCell = new Cell() { IsAlive = true };
            bool result = RulesOfLife.WhatsNext(currentCell, 2);
            Assert.IsTrue(result);
        }
        //komórka żywa i ma więcej niż trzech sąsiadów umiera
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        public void WhenCellIsAliveAndHasMoreThanThreeNeighboursIsDeadTestCase(int aliveNeighbours)
        {
            Cell currentCell = new Cell() { IsAlive = true };
            bool result = RulesOfLife.WhatsNext(currentCell, 4);
            Assert.IsFalse(result);

        }
        //jeśli komórka jest martwa a liczba sąsiadów wynosi 3 to ożywa
        [TestCase(3)]
        public void WhenCellHasThreeNeighboursAndIsDeadBecomeAliveTestCase(int aliveNeighbours)
        {
            Cell currentCell = new Cell() { IsAlive = false };
            bool result = RulesOfLife.WhatsNext(currentCell, 3);
            Assert.IsTrue(result);


        }


    }
}
