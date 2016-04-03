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
        public void Kiedy1sasiadZywy_i_komorkaZywa_to_smiercKomorce()
        {
            Cell currentCell = new Cell() { IsAlive = true };

            bool result = anotherClass.WhatsNext(currentCell, 1);

            Assert.IsFalse(result);
        }

     
        [Test]
    public void Kiedy2sasiadowZywych_i_komorkaZywa_to_KomorkaZywa()
    {
        Cell currentCell = new Cell() { IsAlive = true };

        bool result = anotherClass.WhatsNext(currentCell, 2);

        Assert.IsTrue(result);
    }

        [Test]
        public void Kiedy3sasiadowZywych_i_KomorkaZywa_to_KomorkaZywa()
        {
            Cell currentCell = new Cell() { IsAlive = true};
            bool result = anotherClass.WhatsNext(currentCell, 3);
            Assert.IsTrue(result);

        }

        [Test]
        public void Kiedy4sasiadowZywych_i_komorkaZywa_to_KomorkaMusiUmrzec()
        {
            Cell currentCell = new Cell() { IsAlive = true };

            bool result = anotherClass.WhatsNext(currentCell, 4);

            Assert.IsFalse(result);
        }

        [Test]
        public void Kiedy5sasiadowZywych_i_komorkaZywa_to_KomorkaUmiera()
        {
            Cell currentCell = new Cell() { IsAlive = true };
            bool result = anotherClass.WhatsNext(currentCell, 5);
            Assert.IsFalse(result);
        }

        [Test]
        public void Kiedy6sasiadowZywych_i_komorkaZywa_to_KomorkaUmiera()
        {
            Cell currentCell = new Cell() { IsAlive = true };
            bool result = anotherClass.WhatsNext(currentCell, 6);
            Assert.IsFalse(result);
        }

        [Test]
        public void Kiedy7sasiadowZywych_i_komorkaZywa_to_KomorkaUmiera()
        {
            Cell currentCell = new Cell() { IsAlive = true };
            bool result = anotherClass.WhatsNext(currentCell, 7);
            Assert.IsFalse(result);
        }

        [Test]
        public void Kiedy8sasiadowZywych_i_komorkaZywa_to_KomorkaUmiera()
        {
            Cell currentCell = new Cell() { IsAlive = true };
            bool result = anotherClass.WhatsNext(currentCell, 8);
            Assert.IsFalse(result);
        }

        [Test]
        public void Kiedy3sasiadowZywych_i_komorkaMartwa_to_KomorkaOzywa()
        {
            Cell currentCell = new Cell() { IsAlive = false };

            bool result = anotherClass.WhatsNext(currentCell, 3);

            Assert.IsTrue(result);
        }

        [Test]

        public void Kiedy1sasiadZywy_i_komorkaMartwa_to_KomorkaMartwa()
        {
            Cell currentCell = new Cell() { IsAlive = false };

            bool result = anotherClass.WhatsNext(currentCell, 1);

            Assert.IsFalse(result);
        }
        [Test]

        public void Kiedy2sasiadowZywych_i_komorkaMartwa_to_KomorkaMartwa()
        {
            Cell currentCell = new Cell() { IsAlive = false };

            bool result = anotherClass.WhatsNext(currentCell, 2);

            Assert.IsFalse(result);
        }

        [Test]

        public void Kiedy4sasiadowZywych_i_komorkaMartwa_to_KomorkaMartwa()
        {
            Cell currentCell = new Cell() { IsAlive = false };

            bool result = anotherClass.WhatsNext(currentCell, 4);

            Assert.IsFalse(result);
        }

        [Test]

        public void Kiedy5sasiadowZywych_i_komorkaMartwa_to_KomorkaMartwa()
        {
            Cell currentCell = new Cell() { IsAlive = false };

            bool result = anotherClass.WhatsNext(currentCell, 5);

            Assert.IsFalse(result);
        }

        [Test]

        public void Kiedy6sasiadowZywych_i_komorkaMartwa_to_KomorkaMartwa()
        {
            Cell currentCell = new Cell() { IsAlive = false };

            bool result = anotherClass.WhatsNext(currentCell, 6);

            Assert.IsFalse(result);
        }

        [Test]

        public void Kiedy7sasiadowZywych_i_komorkaMartwa_to_KomorkaMartwa()
        {
            Cell currentCell = new Cell() { IsAlive = false };

            bool result = anotherClass.WhatsNext(currentCell, 7);

            Assert.IsFalse(result);
        }

        [Test]

        public void Kiedy8sasiadowZywych_i_komorkaMartwa_to_KomorkaMartwa()
        {
            Cell currentCell = new Cell() { IsAlive = false };

            bool result = anotherClass.WhatsNext(currentCell, 8);

            Assert.IsFalse(result);
        }

    }


}
