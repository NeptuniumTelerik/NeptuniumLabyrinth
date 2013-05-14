using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labyrinth;

namespace LabyrinthGameProjectTest
{
	[TestClass]
	public class LabyrinthMatrixTests
	{
		[TestMethod]
		public void TestLabyrinthMatrixConstructor()
		{
			int matrixSize = 3;
			LabyrinthMatrix labyrinthMatrix = new LabyrinthMatrix(matrixSize, matrixSize);

			Assert.AreEqual(matrixSize, labyrinthMatrix.Matrix.GetLength(0));
			Assert.AreEqual(matrixSize, labyrinthMatrix.Matrix.GetLength(1));
		}

		[TestMethod]
		public void TestGenerateLabyrinthMatrix()
		{
			int matrixSize = 4;
			LabyrinthMatrix labyrinthMatrix = new LabyrinthMatrix(matrixSize, matrixSize);
			int numberOfGeneratedMatrix = 1000; //min 1000; number adequate to test random generator
			if (numberOfGeneratedMatrix < 1000)
			{
				throw new Exception("The variable numberOfGeneratedMatrix must be minimum 1000");
			}

			// create matrix to count blocks type in the matrix
			int[,] passableBlocksCountMatrix = new int[matrixSize, matrixSize];
			int[,] unpassableBlocksCountMatrix = new int[matrixSize, matrixSize];
			passableBlocksCountMatrix = GenerateCounterMatrix(passableBlocksCountMatrix);
			unpassableBlocksCountMatrix = passableBlocksCountMatrix.Clone() as int[,];

			//generate N random matrix and infill the twoo counter matrices (passableBlocksCountMatrix and unpassableBlocksCountMatrix)
			for (int i = 0; i < numberOfGeneratedMatrix; i++)
			{
				labyrinthMatrix.GenerateLabyrinthMatrix();
				for (int col = 0; col < matrixSize; col++)
				{
					for (int row = 0; row < matrixSize; row++)
					{
						if (labyrinthMatrix.Matrix[col,row] == '-')
						{
							passableBlocksCountMatrix[col, row]++;
						}
						else
						{
							unpassableBlocksCountMatrix[col, row]++;
						}
					}					
				}
			}

			// test for count of random elements by two counter matrix
			bool isRandom = true;
			int propabilityOfCountOfBlocks = (int)(numberOfGeneratedMatrix * 0.45);
			int playerCoordinate = matrixSize / 2;
			for (int col = 0; col < matrixSize; col++)
			{
				for (int row = 0; row < matrixSize; row++)
				{
					if (col == playerCoordinate && row == playerCoordinate)
					{
						continue;
					}
					if (passableBlocksCountMatrix[col, row] < propabilityOfCountOfBlocks ||
						unpassableBlocksCountMatrix[col, row] < propabilityOfCountOfBlocks)
					{
						isRandom = false;
					}
				}
			}
			Assert.IsTrue(isRandom);
		}

		private int[,] GenerateCounterMatrix(int[,] matrix)
		{
			for (int col = 0; col < matrix.GetLength(0) ; col++)
			{
				for (int row = 0; row < matrix.GetLength(1); row++)
				{
					matrix[row, col] = 0;
				}
			}
			return matrix;
		}

		[TestMethod]
		public void TestIsPassableWithUnpassableBlocks()
		{
			int matrixSize = 3;
			LabyrinthMatrix labyrinthMatrix = new LabyrinthMatrix(matrixSize, matrixSize);
			char blockBody = 'X';
			labyrinthMatrix = GenerateLabyrinthMatrix(labyrinthMatrix, blockBody);

			Assert.IsFalse(labyrinthMatrix.IsPassable(0, 1)); //go to up
			Assert.IsFalse(labyrinthMatrix.IsPassable(1, 2)); //go to right
			Assert.IsFalse(labyrinthMatrix.IsPassable(2, 1)); //go to down
			Assert.IsFalse(labyrinthMatrix.IsPassable(1, 0)); //go to left
		}

		[TestMethod]
		public void TestIsPassableWithPassableBlocks()
		{
			int matrixSize = 3;
			LabyrinthMatrix labyrinthMatrix = new LabyrinthMatrix(matrixSize, matrixSize);
			char blockBody = '-';
			labyrinthMatrix = GenerateLabyrinthMatrix(labyrinthMatrix, blockBody);

			Assert.IsTrue(labyrinthMatrix.IsPassable(0, 1)); //go to up
			Assert.IsTrue(labyrinthMatrix.IsPassable(1, 2)); //go to right
			Assert.IsTrue(labyrinthMatrix.IsPassable(2, 1)); //go to down
			Assert.IsTrue(labyrinthMatrix.IsPassable(1, 0)); //go to left
		}

		private LabyrinthMatrix GenerateLabyrinthMatrix(LabyrinthMatrix matrix, char blockBody)
		{
			LabyrinthMatrix labyrinthMatrix = matrix;
			for (int row = 0; row < labyrinthMatrix.Matrix.GetLength(0); row++)
			{
				for (int col = 0; col < labyrinthMatrix.Matrix.GetLength(1); col++)
				{
					labyrinthMatrix.Matrix[row, col] = blockBody;
				}
			}
			return labyrinthMatrix;
		}

		[TestMethod]
		public void TestIsOutsideMatrix()
		{
			int matrixSize = 3;
			LabyrinthMatrix labyrinthMatrix = new LabyrinthMatrix(matrixSize, matrixSize);

			//testing inside of the matrix
			for (int row = 1; row < labyrinthMatrix.Matrix.GetLength(0) - 1; row++)
			{
				for (int col = 1; col < labyrinthMatrix.Matrix.GetLength(1) - 1; col++)
				{
					Assert.IsFalse(	labyrinthMatrix.isOutsideMatrix(row, col),
									String.Format("Row: {0}; Col: {1}", col, col)
									);
				}
			}

			//testing outside of the matrix - horizontaly boundary
			int lastRow = labyrinthMatrix.Matrix.GetLength(0)-1;
			for (int row = 0; row < labyrinthMatrix.Matrix.GetLength(0); row += lastRow)
			{
				for (int col = 0; col < labyrinthMatrix.Matrix.GetLength(1); col++)
				{
					Assert.IsTrue( labyrinthMatrix.isOutsideMatrix(row, col),
									String.Format("Row: {0}; Col: {1}", col, col)
									);
				}			
			}

			//testing outside of the matrix - verticaly boundary
			int lastCol = labyrinthMatrix.Matrix.GetLength(1) - 1;
			for (int col = 0; col < labyrinthMatrix.Matrix.GetLength(1); col += lastCol)
			{
				for (int row = 0; row < labyrinthMatrix.Matrix.GetLength(1); row++)
				{
					Assert.IsTrue( labyrinthMatrix.isOutsideMatrix(row, col),
									String.Format("Row: {0}; Col: {1}", col, col)
									);
				}
			}
		}
	}
}