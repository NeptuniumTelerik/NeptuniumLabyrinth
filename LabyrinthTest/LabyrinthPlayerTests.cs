using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labyrinth;

namespace LabyrinthGameProjectTest
{
    [TestClass]
    public class LabyrinthPlayerTests
    {
        [TestMethod]
        public void TestPlayerConstructor()
        {
            LabyrinthPlayer player = new LabyrinthPlayer(4, 5);
            Assert.AreEqual(4, player.RowPosition);
            Assert.AreEqual(5, player.ColPosition);
        }

        [TestMethod]
        public void TestSetAndGetProperties()
        {
            LabyrinthPlayer player = new LabyrinthPlayer(4, 5);
            player.RowPosition = 2;
            player.ColPosition = 3;
            Assert.AreEqual(2, player.RowPosition);
            Assert.AreEqual(3, player.ColPosition);
        }

        [TestMethod]
        public void TestMoveLeft()
        {
            LabyrinthPlayer player = new LabyrinthPlayer(4, 5);
            player.MoveLeft();
            Assert.AreEqual(4, player.RowPosition);
            Assert.AreEqual(4, player.ColPosition);
        }

        [TestMethod]
        public void TestMoveRight()
        {
            LabyrinthPlayer player = new LabyrinthPlayer(4, 5);
            player.MoveRight();
            Assert.AreEqual(4, player.RowPosition);
            Assert.AreEqual(6, player.ColPosition);
        }

        [TestMethod]
        public void TestMoveUp()
        {
            LabyrinthPlayer player = new LabyrinthPlayer(4, 5);
            player.MoveUp();
            Assert.AreEqual(3, player.RowPosition);
            Assert.AreEqual(5, player.ColPosition);
        }

        [TestMethod]
        public void TestMoveDown()
        {
            LabyrinthPlayer player = new LabyrinthPlayer(4, 5);
            player.MoveDown();
            Assert.AreEqual(5, player.RowPosition);
            Assert.AreEqual(5, player.ColPosition);
        }
    }
}
