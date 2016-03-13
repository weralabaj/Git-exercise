using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GameOfLife.Tests
{
    [TestFixture]
    class MyTest
    {
        [Test]
        public void Test4()
        {
            Cell currentCell = new Cell() { IsAlive = true };

            bool result = F.WhatsNext(currentCell, 1);

            Assert.IsFalse(result);
        }

    }
}
