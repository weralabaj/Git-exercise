using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cell
{
    public bool IsAlive { get; set; }
    
}
/*

    pokasowałem to co wydawało mi się, że zaciemnia obraz co ma robić klasa i poprawiłem nazwy metod oraz ich logikę

*/
public class RulesOfLife
{
  
    public static bool WhatsNext(Cell currentCell, int aliveNeighbours)
    { 
        //1.Każda komórka, posiadająca mniej niż dwóch żywych sąsiadów umiera
        if ((currentCell.IsAlive) && (aliveNeighbours < 2))
        {
            return false;
        }
        //2.Każda komórka, która posiada dwóch lub trzech żywych sąsiadów przeżywa
        else if ((currentCell.IsAlive) && (aliveNeighbours == 3 || aliveNeighbours == 2))
        {
            return true;
        }
        //3.Każda komórka posiadająca więcej niż trzech żywych sąsiadów umiera
        else if ((currentCell.IsAlive) && (aliveNeighbours > 3))
        {
            return false;
        }
        //4.Komórka będąca oznaczona jako martwa a posiadająca dokładnie trzech sąsiadów staje się komórką żywą
        else if ((!currentCell.IsAlive) && (aliveNeighbours == 3))
        {
            return true;
        }

        return false;


    }

}


