using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Cell
    {
        public bool IsAlive { get; set; }
    }
    public class anotherClass
    {
        public static bool WhatsNext(Cell currentCell, int aliveNeighbours)
        {
            if (currentCell.IsAlive && aliveNeighbours <= 2)
                return false;
            return true;
        }
    }
}
