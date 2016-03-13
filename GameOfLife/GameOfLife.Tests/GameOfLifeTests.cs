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
            public void GameOfLifeTestMethod()
            {
                Cell currentCell = new Cell() { IsAlive = true };

                bool result = RulesOfLife.WhatsNext(currentCell, 1);

                Assert.IsFalse(result);
            }

           
    
}
}
