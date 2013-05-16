using System;
using System.Linq;

namespace Labyrinth
{
    public class LabyrinthMatrix:IMatrix
    {
        private readonly Random randomGenerator = new Random();
        public readonly char UnPassableBlock = 'X';
        public readonly char PassableBlock = '-';

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

        private char GetRandomSymbol()
        {
            int randomValue = randomGenerator.Next(0, 2);
            switch (randomValue)
            {
                case 0: return this.PassableBlock;
                default: return this.UnPassableBlock;
            }
        }

        public bool IsPassable(int row, int col)
        {
                bool isPassable = (this.matrix[row, col] == this.PassableBlock);
                return isPassable;
        }

        public bool IsOutsideMatrix(int row, int col)
        {
            bool outsideRows = row == 0 || row == this.matrix.GetLength(0) - 1;
            bool outsideCols = col == 0 || col == this.Matrix.GetLength(1) - 1;

            return outsideRows || outsideCols;
        }

        public void GenerateLabyrinthMatrix()
        {
            char[,] testMatrix;
            int rowsCount = this.Matrix.GetLength(0);
            int colsCount = this.Matrix.GetLength(1);
            int exitsCount = 0;

            do
            {
                this.Matrix = CreateRandomMatrix(rowsCount,colsCount );

                testMatrix = this.Matrix.Clone() as char[,];
                exitsCount = CountLabyrinthExits(rowsCount / 2, colsCount / 2, testMatrix);
            } while (exitsCount == 0);
        }

        private char[,] CreateRandomMatrix(int rows,int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = GetRandomSymbol();
                }
            }

            int middle = this.matrix.GetLength(0) / 2;
            matrix[middle, middle] = this.PassableBlock;

            return matrix;
        }

        public int CountLabyrinthExits(int startRow, int startCol, char[,] labyrintMatrix)
        {
            labyrintMatrix[startRow, startCol] = this.UnPassableBlock;

            if (startRow == 0 || startRow == labyrintMatrix.GetLength(0) - 1 || 
                startCol == 0 || startCol == labyrintMatrix.GetLength(1) - 1)
            {
                return 1;
            }

            int exitsCount = 0;

            if (labyrintMatrix[startRow - 1, startCol] == this.PassableBlock)
            {
                exitsCount += CountLabyrinthExits(startRow - 1, startCol, labyrintMatrix);
            }
            if (labyrintMatrix[startRow + 1, startCol] == this.PassableBlock)
            {
                exitsCount += CountLabyrinthExits(startRow + 1, startCol, labyrintMatrix);
            }
            if (labyrintMatrix[startRow, startCol - 1] == this.PassableBlock)
            {
                exitsCount += CountLabyrinthExits(startRow, startCol - 1, labyrintMatrix);
            }
            if (labyrintMatrix[startRow, startCol + 1] == this.PassableBlock)
            {
                exitsCount += CountLabyrinthExits(startRow, startCol + 1, labyrintMatrix);
            }

            return exitsCount;
        }
    }
}
