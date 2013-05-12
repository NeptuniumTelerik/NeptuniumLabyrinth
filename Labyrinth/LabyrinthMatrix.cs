using System;
using System.Linq;

namespace Labyrinth
{
    public class LabyrinthMatrix
    {
        private readonly Random randomGenerator = new Random();
        private readonly char unPassableBlock = 'X';
        private readonly char passableBlock = '-';

        private char[,] matrix;

        public char[,] Matrix
        {
            get
            {
                return this.matrix;
            }
            set
            {
                this.matrix = value;
            }
        }

        public LabyrinthMatrix(int rows, int cols)
        {
            this.Matrix = new char[rows,cols];
        }

        public void GenerateLabyrinthMatrix()
        {
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    this.matrix[row, col] = GetRandomSymbol();
                }
            }

            int middle = this.matrix.GetLength(0) / 2;
            this.matrix[middle, middle] = this.passableBlock;
        }

        private char GetRandomSymbol()
        {
            int randomValue = randomGenerator.Next(0, 2);
            switch (randomValue)
            {
                case 0: return this.passableBlock;
                default: return this.unPassableBlock;
            }
        }

        public bool IsPassable(int row, int col)
        {
                bool isPassable = (this.matrix[row, col] == this.passableBlock);
                return isPassable;
        }

        public bool isOutsideMatrix(int row, int col)
        {
            bool outsideRows = row == 0 || row == this.matrix.GetLength(0) - 1;
            bool outsideCols = col == 0 || col == this.Matrix.GetLength(1) - 1;

            return outsideRows || outsideCols;
        }
    }
}
