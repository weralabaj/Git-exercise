using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            if (currentCell.IsAlive && aliveNeighbours < 2 || currentCell.IsAlive && aliveNeighbours > 3)
            {
                return false;
            }
            if ((currentCell.IsAlive == false) && aliveNeighbours <= 2 || currentCell.IsAlive == false && aliveNeighbours > 3)
            {
                return false;
            }

            return true;
        } 
           
    }
}
