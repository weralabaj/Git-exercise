using System.Collections.Generic;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace GameOfLife.Tests
{
    public class Cell_A
    {
        public bool IsAlive { get; set; }
    }

    public class A
    {
        public static bool WhatsNext(Cell_A[,] cells, int current_X, int current_Y)
        {
            // znajdz sasiadow
            var neighbours = new List<Cell_A>()
            {
                cells[current_X-1,current_Y-1],
                cells[current_X-1,current_Y],
                cells[current_X-1,current_Y+1],
                cells[current_X,current_Y-1],
                cells[current_X,current_Y+1],
                cells[current_X+1,current_Y-1],
                cells[current_X+1,current_Y],
                cells[current_X+1,current_Y+1]
            }; // można użyć pętli do wyciągnięcia sąsiadów

            int aliveNeighboursCount = 0;
            foreach (var neighbour in neighbours)
            {
                if (neighbour.IsAlive)
                    aliveNeighboursCount++;
            }

            if (aliveNeighboursCount <= 2)
                return false;

            return true;
        }
    }

    public class Cell_B
    {
        public Cell_B Neighbour1;
        public Cell_B Neighbour2;
        public Cell_B Neighbour3;
        public Cell_B Neighbour4;
        public Cell_B Neighbour5;
        public Cell_B Neighbour6;
        public Cell_B Neighbour7;
        public Cell_B Neighbour8;

        public bool IsAlive { get; set; }
    }

    public class B
    {
        public bool WhatsNext(Cell_B currentCell)
        {
            int aliveNeighboursCount = 0;
            if (currentCell.Neighbour1.IsAlive)
                aliveNeighboursCount++;
            ///... i tak dla wszystkich 8
            // znajdz sasiadow

            if (aliveNeighboursCount <= 2)
                return false;

            return true;
        }
    }

    public class Cell_C
    {
        public List<Cell_C> Neighbours { get; set; }
        public bool IsAlive { get; set; }
    }

    public class C
    {
        public static bool WhatsNext(Cell_C currentCell)
        {
            int aliveNeighboursCount = 0;
            foreach (var neighbour in currentCell.Neighbours)
            {
                if (neighbour.IsAlive)
                    aliveNeighboursCount++;
            }

            if (aliveNeighboursCount <= 2)
                return false;

            return true;
        }
    }

    public class Cell_D
    {
        public bool IsAlive { get; set; }
        public List<Cell_D> AliveNeighbours { get; set; }
    }

    public class Cell_E
    {
        public bool IsAlive { get; set; }
        public int AliveNeighbours { get; set; }
        
    }

    public class E
    {
        public static bool WhatsNext(Cell_E currentCell)
        {
            if (currentCell.IsAlive && currentCell.AliveNeighbours <= 2)
                return false;
            return true;
        }
    }

    public class Cell_F
    {
        public bool  IsAlive { get; set; }
    }

    public class F
    {
        public static bool WhatsNext(Cell_F currentCell, int aliveNeighbours)
        {
            if (currentCell.IsAlive && aliveNeighbours <= 2)
                return false;
            return true;
        }
    }


    [TestFixture]
    public class RulesOfLifeTest
    {
        [Test]
        public void Test4()
        {
            Cell_F currentCell = new Cell_F() { IsAlive = true };

            bool result = F.WhatsNext(currentCell, 1);

            Assert.IsFalse(result);
        }

        [Test]
        public void Test3()
        {
            Cell_E currentCell = new Cell_E() {IsAlive = true, AliveNeighbours = 1};

            bool result = E.WhatsNext(currentCell);

            Assert.IsFalse(result);
        }

        [Test]
        public void Test2()
        {
            Cell_A[,] array = new Cell_A[3,3];
            array[0,0] = new Cell_A() {IsAlive = true};
            array[1,1] = new Cell_A() { IsAlive = true };
            array[0,1] = new Cell_A() ;
            array[0,2] = new Cell_A() ;
            array[1,0] = new Cell_A() ;
            array[1,2] = new Cell_A() ;
            array[2,0] = new Cell_A() ;
            array[2,1] = new Cell_A() ;
            array[2,2] = new Cell_A() ;

            bool result = A.WhatsNext(array, 1, 1);

            Assert.IsFalse(result);
        }

        [Test]
        public void Test()
        {
            // do funkcji przekazujemy listę sąsiadów
            // komórka jest żywa
            // 1 sąsiad jest żywy
            Cell_C currentCell = new Cell_C()
            {
                IsAlive = true,
                Neighbours = new List<Cell_C>()
                {
                    new Cell_C() {IsAlive = true},
                    new Cell_C(),
                    new Cell_C(),
                    new Cell_C(),
                    new Cell_C(),
                    new Cell_C(),
                    new Cell_C(),
                    new Cell_C()
                }
            };

            bool result = C.WhatsNext(currentCell);
            // 
            // => komórka umiera

            Assert.IsFalse(result);
        }
    }
}
