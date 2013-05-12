using Labyrinth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LabyrinthGameProjectTest
{
    /// <summary>
    ///This is a test class for LabyrinthEngineTest and is intended
    ///to contain all LabyrinthEngineTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LabyrinthEngineTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///A test for HandleInput
        ///</summary>
        [TestMethod()]
        public void HandleInputTest()
        {
            LabyrinthEngine target = new LabyrinthEngine(); // TODO: Initialize to an appropriate value
            target.HandleInput();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LabyrinthEngine Constructor
        ///</summary>
        [TestMethod()]
        public void LabyrinthEngineConstructorTest()
        {
            LabyrinthEngine target = new LabyrinthEngine();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ShowInputMessage
        ///</summary>
        [TestMethod()]
        public void ShowInputMessageTest()
        {
            LabyrinthEngine target = new LabyrinthEngine(); // TODO: Initialize to an appropriate value
            target.ShowInputMessage();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ShowLabyrinth
        ///</summary>
        [TestMethod()]
        public void ShowLabyrinthTest()
        {
            LabyrinthEngine target = new LabyrinthEngine(); // TODO: Initialize to an appropriate value
            LabyrinthMatrix labyrinth = null; // TODO: Initialize to an appropriate value
            target.ShowLabyrinth(labyrinth);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Matrix
        ///</summary>
        [TestMethod()]
        public void MatrixTest()
        {
            LabyrinthEngine target = new LabyrinthEngine(); // TODO: Initialize to an appropriate value
            LabyrinthMatrix expected = null; // TODO: Initialize to an appropriate value
            LabyrinthMatrix actual;
            target.Matrix = expected;
            actual = target.Matrix;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
