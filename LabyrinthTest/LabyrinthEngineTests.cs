using Labyrinth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace LabyrinthGameProjectTest
{
    /// <summary>
    ///This is a test class for LabyrinthEngineTest and is intended
    ///to contain all LabyrinthEngineTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LabyrinthEngineTests
    {

        /// <summary>
        ///A test for LabyrinthEngine Constructor
        ///</summary>
        [TestMethod()]
        public void LabyrinthEngineConstructorTest()
        {
            LabyrinthEngine testEngine = new LabyrinthEngine();
            //Checking for exceptions.
        }

        static char[,] mockLabyrinth = {{'-', 'X', 'X', '-', 'X', '-', 'X'},
                {'-', '-', '-', '-', '-', '-', '-'},
                {'-', '-', 'X', '-', 'X', '-', '-'},
                {'-', '-', '-', '-', '-', '-', '-'},
                {'-', '-', 'X', '-', 'X', 'X', '-'},
                {'-', 'X', 'X', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-', '-'}};


        //        /// <summary>
        //        ///A test for DrawLabyrinth
        //        ///</summary>
        //        [TestMethod()]
        //        public void DrawLabyrinthTest()
        //        {
        //            LabyrinthEngine target = new LabyrinthEngine(); // TODO: Initialize to an appropriate value
        //            target.DrawLabyrinth();
        //            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        //        }

        /// <summary>
        ///A test for GameMenuControl
        ///</summary>
        [TestMethod()]
        public void GameMenuControlExitTest()
        {            
            //LabyrinthEngine target = new LabyrinthEngine(); 
            //target.GameMenuControl();
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        //        /// <summary>
        //        ///A test for MovePlayer
        //        ///</summary>
        //        [TestMethod()]
        //        public void MovePlayerTest()
        //        {
        //            LabyrinthEngine target = new LabyrinthEngine(); // TODO: Initialize to an appropriate value
        //            string value = string.Empty; // TODO: Initialize to an appropriate value
        //            bool expected = false; // TODO: Initialize to an appropriate value
        //            bool actual;
        //            actual = target.MovePlayer(value);
        //            Assert.AreEqual(expected, actual);
        //            Assert.Inconclusive("Verify the correctness of this test method.");
        //        }

        //        /// <summary>
        //        ///A test for PlayerControl
        //        ///</summary>
        //        [TestMethod()]
        //        public void PlayerControlTest()
        //        {
        //            LabyrinthEngine target = new LabyrinthEngine(); // TODO: Initialize to an appropriate value
        //            target.PlayerControl();
        //            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        //        }

        //        /// <summary>
        //        ///A test for ProcessInput
        //        ///</summary>
        //        [TestMethod()]
        //        public void ProcessInputTest()
        //        {
        //            LabyrinthEngine target = new LabyrinthEngine(); // TODO: Initialize to an appropriate value
        //            string expected = string.Empty; // TODO: Initialize to an appropriate value
        //            string actual;
        //            actual = target.ProcessInput();
        //            Assert.AreEqual(expected, actual);
        //            Assert.Inconclusive("Verify the correctness of this test method.");
        //        }
    }
}
