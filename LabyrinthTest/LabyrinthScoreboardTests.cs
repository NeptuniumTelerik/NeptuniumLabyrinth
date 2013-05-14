using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labyrinth;
using System.Collections.Generic;

namespace LabyrinthGameProjectTest
{
    [TestClass]
    public class LabyrinthScoreboardTests
    {
        [TestMethod]
        public void TestScoreBoardConstructor()
        {
            TopFiveScoreboard scoreboard = new TopFiveScoreboard();
            int actual = scoreboard.Scoreboard.Count;
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TestHandleScoreboardWithOnePlayer()
        {
            TopFiveScoreboard scoreboard = new TopFiveScoreboard();
            scoreboard.HandleScoreboard(5, "gosho");
            int actual = scoreboard.Scoreboard.Count;
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestHandleScoreboardWithFivePlayer()
        {
            TopFiveScoreboard scoreboard = new TopFiveScoreboard();
            scoreboard.HandleScoreboard(5, "gosho");
            scoreboard.HandleScoreboard(6, "gosho");
            scoreboard.HandleScoreboard(2, "gosho");
            scoreboard.HandleScoreboard(1, "gosho");
            scoreboard.HandleScoreboard(9, "gosho");
            int actual = scoreboard.Scoreboard.Count;
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void TestHandleScoreboardSortingPriveteMethod()
        {
            TopFiveScoreboard scoreboard = new TopFiveScoreboard();
            scoreboard.HandleScoreboard(5, "Mustafa");
            scoreboard.HandleScoreboard(6, "Az");
            scoreboard.HandleScoreboard(2, "Asen");
            scoreboard.HandleScoreboard(1, "Pesho");
            scoreboard.HandleScoreboard(9, "gosho");

            List<Tuple<uint, string>> expectedScoreBoard = new List<Tuple<uint, string>>();
            expectedScoreBoard.Add(new Tuple<uint, string>(1, "Pesho"));
            expectedScoreBoard.Add(new Tuple<uint, string>(2, "Asen"));
            expectedScoreBoard.Add(new Tuple<uint, string>(5, "Mustafa"));
            expectedScoreBoard.Add(new Tuple<uint, string>(6, "Az"));
            expectedScoreBoard.Add(new Tuple<uint, string>(9, "gosho"));
            List<Tuple<uint, string>> actual = scoreboard.Scoreboard;
            Assert.AreEqual<Tuple<uint, string>>(expectedScoreBoard[0], actual[0]);
            Assert.AreEqual<Tuple<uint, string>>(expectedScoreBoard[1], actual[1]);
            Assert.AreEqual<Tuple<uint, string>>(expectedScoreBoard[2], actual[2]);
            Assert.AreEqual<Tuple<uint, string>>(expectedScoreBoard[3], actual[3]);
            Assert.AreEqual<Tuple<uint, string>>(expectedScoreBoard[4], actual[4]);
        }

        /// <summary>
        /// Adding sith player wich is better than some of the first Five players and see if he is going
        /// on the right place
        /// </summary>

        [TestMethod]
        public void TestHandleScoreboardCaseWithSixthPlayerBetterThanRest()
        {
            TopFiveScoreboard scoreboard = new TopFiveScoreboard();
            scoreboard.HandleScoreboard(5, "Mustafa");
            scoreboard.HandleScoreboard(6, "Az");
            scoreboard.HandleScoreboard(2, "Asen");
            scoreboard.HandleScoreboard(1, "Pesho");
            scoreboard.HandleScoreboard(9, "gosho");
            scoreboard.HandleScoreboard(3, "maicon");
           

            List<Tuple<uint, string>> expectedScoreBoard = new List<Tuple<uint, string>>();
            expectedScoreBoard.Add(new Tuple<uint, string>(1, "Pesho"));
            expectedScoreBoard.Add(new Tuple<uint, string>(2, "Asen"));
            expectedScoreBoard.Add(new Tuple<uint, string>(3, "maicon"));
            expectedScoreBoard.Add(new Tuple<uint, string>(5, "Mustafa"));
            expectedScoreBoard.Add(new Tuple<uint, string>(6, "Az"));
            expectedScoreBoard.Add(new Tuple<uint, string>(9, "gosho"));
            List<Tuple<uint, string>> actual = scoreboard.Scoreboard;
            Assert.AreEqual<Tuple<uint, string>>(expectedScoreBoard[3], actual[3]);
        }

        /// <summary>
        /// Adding sixt player to the scoreboard wich is worse than everyone
        /// it shoudn't be in the scoreboard at all
        /// </summary>
        [TestMethod]
        public void TestHandleScoreboardWithSixthPlayerWorseThanRest()
        {
            TopFiveScoreboard scoreboard = new TopFiveScoreboard();
            scoreboard.HandleScoreboard(5, "Mustafa");
            scoreboard.HandleScoreboard(6, "Az");
            scoreboard.HandleScoreboard(2, "Asen");
            scoreboard.HandleScoreboard(1, "Pesho");
            scoreboard.HandleScoreboard(9, "gosho");
            scoreboard.HandleScoreboard(10, "ronaldo");
           bool actual = scoreboard.Scoreboard.Contains(new Tuple<uint,string>(10,"ronaldo"));
           Assert.AreEqual(false, actual);
        }
        //TODO: somehow to test showScoreBoard
    }
}
