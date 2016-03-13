using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cell
{
    public bool IsAlive { get; set; }
}

public class RulesOfLife
{
    public static bool WhatsNext(Cell currentCell, int aliveNeighbours)
    {
        if (currentCell.IsAlive && (aliveNeighbours < 2 || aliveNeighbours > 3))
            return false;
        return true;
    }
}


