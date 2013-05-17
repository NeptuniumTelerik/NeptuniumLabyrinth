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


        /// <summary>
        ///A test for GameMenuControl
        ///</summary>
		//[TestMethod()] - this tests takes forever
        public void GameMenuControlExitTest()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
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

        }

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

    }
}
