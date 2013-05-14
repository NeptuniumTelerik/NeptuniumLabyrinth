//using Labyrinth;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace LabyrinthGameProjectTest
//{    
//    /// <summary>
//    ///This is a test class for LabyrinthEngineTest and is intended
//    ///to contain all LabyrinthEngineTest Unit Tests
//    ///</summary>
//    [TestClass()]
//    public class LabyrinthEngineTests
//    {
//        private TestContext testContextInstance;
//        /// <summary>
//        ///Gets or sets the test context which provides
//        ///information about and functionality for the current test run.
//        ///</summary>
//        public TestContext TestContext
//        {
//            get
//            {
//                return testContextInstance;
//            }
//            set
//            {
//                testContextInstance = value;
//            }
//        }

//        #region Additional test attributes
//        // 
//        //You can use the following additional attributes as you write your tests:
//        //
//        //Use ClassInitialize to run code before running the first test in the class
//        //[ClassInitialize()]
//        //public static void MyClassInitialize(TestContext testContext)
//        //{
//        //}
//        //
//        //Use ClassCleanup to run code after all tests in a class have run
//        //[ClassCleanup()]
//        //public static void MyClassCleanup()
//        //{
//        //}
//        //
//        //Use TestInitialize to run code before running each test
//        //[TestInitialize()]
//        //public void MyTestInitialize()
//        //{
//        //}
//        //
//        //Use TestCleanup to run code after each test has run
//        //[TestCleanup()]
//        //public void MyTestCleanup()
//        //{
//        //}
//        //
//        #endregion


//        /// <summary>
//        ///A test for LabyrinthEngine Constructor
//        ///</summary>
//        [TestMethod()]
//        public void LabyrinthEngineConstructorTest()
//        {
//            LabyrinthEngine target = new LabyrinthEngine();
//            Assert.Inconclusive("TODO: Implement code to verify target");
//        }

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

//        /// <summary>
//        ///A test for GameMenuControl
//        ///</summary>
//        [TestMethod()]
//        public void GameMenuControlTest()
//        {
//            LabyrinthEngine target = new LabyrinthEngine(); // TODO: Initialize to an appropriate value
//            target.GameMenuControl();
//            Assert.Inconclusive("A method that does not return a value cannot be verified.");
//        }

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
//    }
//}
