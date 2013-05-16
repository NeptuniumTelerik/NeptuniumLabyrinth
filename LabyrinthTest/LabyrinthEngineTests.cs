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
		//[TestMethod()] - this tests takes forever
        public void GameMenuControlExitTest()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                //TopFiveScoreboard scores = new TopFiveScoreboard();
                UserInterfaceSimulation userInterface = new UserInterfaceSimulation();
                userInterface.SimulateInput = "exit";
                LabyrinthEngine testEngine = new LabyrinthEngine();
                testEngine.GameMenuControl();

                StringBuilder expectedStringBuilder = new StringBuilder();
                expectedStringBuilder.Append("Good Bye!");
                expectedStringBuilder.Append(Environment.NewLine);

                string expectedString = expectedStringBuilder.ToString();
                string output = sw.ToString();
                output = output.Substring(output.Length - 11);

                Assert.AreEqual<string>(expectedString, output);
            }

            //LabyrinthEngine target = new LabyrinthEngine(); 
            //target.GameMenuControl();
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        //[TestMethod()] - this tests takes forever
        public void GameMenuControlTopTest()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                TopFiveScoreboard scores = new TopFiveScoreboard();
                UserInterfaceSimulation userInterface = new UserInterfaceSimulation();
                userInterface.SimulateInput = "top";
                LabyrinthEngine testEngine = new LabyrinthEngine();
                testEngine.GameMenuControl();

                StringBuilder expectedStringBuilder = new StringBuilder();
                expectedStringBuilder.Append("The scoreboard is empty.");
                expectedStringBuilder.Append(Environment.NewLine);
                expectedStringBuilder.Append("\nEnter your move (L=left, R=right, U=up, D=down):");
                expectedStringBuilder.Append("Good Bye!");
                expectedStringBuilder.Append(Environment.NewLine);

                string expectedString = expectedStringBuilder.ToString();
                string output = sw.ToString();
                output = output.Substring(output.Length - 86);

                Assert.AreEqual<string>(expectedString, output);
            }

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
