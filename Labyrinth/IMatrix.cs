using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labyrinth
{
   public interface IMatrix
    {
       char[,] Matrix{get;set;}
       void GenerateLabyrinthMatrix();
       bool IsPassable(int row, int col);
       bool isOutsideMatrix(int row, int col);
    }
}
