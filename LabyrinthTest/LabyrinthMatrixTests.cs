﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labyrinth;

namespace LabyrinthGameProjectTest
{
	[TestClass]
	public class LabyrinthMatrixTests
	{
		[TestMethod]
		public void TestIsPassableWithUnpassableBlocks()
		{
			int matrixSize = 3;
			LabyrinthMatrix matrix = new LabyrinthMatrix(matrixSize, matrixSize);
			char blockBody = 'X';
			matrix = GenerateLabyrinthMatrix(matrix, blockBody);

			Assert.AreEqual(false, matrix.IsPassable(0, 1)); //go to up
			Assert.AreEqual(false, matrix.IsPassable(1, 2)); //go to right
			Assert.AreEqual(false, matrix.IsPassable(2, 1)); //go to down
			Assert.AreEqual(false, matrix.IsPassable(1, 0)); //go to left
		}

		[TestMethod]
		public void TestIsPassableWithPassableBlocks()
		{
			int matrixSize = 3;
			LabyrinthMatrix matrix = new LabyrinthMatrix(matrixSize, matrixSize);
			char blockBody = '-';
			matrix = GenerateLabyrinthMatrix(matrix, blockBody);

			Assert.AreEqual(true, matrix.IsPassable(0, 1)); //go to up
			Assert.AreEqual(true, matrix.IsPassable(1, 2)); //go to right
			Assert.AreEqual(true, matrix.IsPassable(2, 1)); //go to down
			Assert.AreEqual(true, matrix.IsPassable(1, 0)); //go to left
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
					Assert.AreEqual(false,
									labyrinthMatrix.isOutsideMatrix(row, col),
									String.Format("Row: {0}; Col: {1}", col, col));
				}
			}

			//testing outside of the matrix - horizontaly boundary
			int lastRow = labyrinthMatrix.Matrix.GetLength(0)-1;
			for (int row = 0; row < labyrinthMatrix.Matrix.GetLength(0); row += lastRow)
			{
				for (int col = 0; col < labyrinthMatrix.Matrix.GetLength(1); col++)
				{
					Assert.AreEqual(true,
									labyrinthMatrix.isOutsideMatrix(row, col),
									String.Format("Row: {0}; Col: {1}", col, col));
				}			
			}

			//testing outside of the matrix - verticaly boundary
			int lastCol = labyrinthMatrix.Matrix.GetLength(1) - 1;
			for (int col = 0; col < labyrinthMatrix.Matrix.GetLength(1); col += lastCol)
			{
				for (int row = 0; row < labyrinthMatrix.Matrix.GetLength(1); row++)
				{
					Assert.AreEqual(true,
									labyrinthMatrix.isOutsideMatrix(row, col),
									String.Format("Row: {0}; Col: {1}", col, col));
				}
			}
		}
	}
}
