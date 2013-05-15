using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labyrinth
{
    public class LabyrinthRenderer
    {
        public IPlayer Player { private get; set; }
        public char[,] Labyrinth {private get; set;}

        public LabyrinthRenderer(IPlayer player, IMatrix labyrinth)
        {
            this.Player = player;
            this.Labyrinth = labyrinth.Matrix;
        }

        public void ConsoleDrawLabyrinth()
        {
            char[,] matrix = this.Labyrinth;

            Console.Clear();

            Console.WriteLine();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == this.Player.RowPosition && col == this.Player.ColPosition)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(this.Player.PlayerSymbol);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.Write(matrix[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
