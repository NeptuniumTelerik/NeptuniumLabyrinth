using System;
using System.IO;
using Labyrinth;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabyrinthGameProjectTest
{

    [TestClass]
    public class LabyrinthRendererTest
    {
        [TestMethod]
        public void TestLabyrintConsolePrint()
        {
            char[,] matrixToTest01 = { 
               {'X','X','X','-','X','X','X'},
               {'X','X','X','-','X','X','X'},
               {'X','X','X','-','X','X','X'},
               {'-','-','-','-','-','-','-'},
               {'X','X','X','-','X','X','X'},
               {'X','X','X','-','X','X','X'},
               {'X','X','X','-','X','X','X'},
            };

            string expected = String.Format(
                "{0}XXX-XXX{0}XXX-XXX{0}XXX-XXX{0}---*---{0}XXX-XXX{0}XXX-XXX{0}XXX-XXX{0}",
                Environment.NewLine);

            LabyrinthPlayer player = new LabyrinthPlayer(7 / 2, 7 / 2);
            LabyrinthMatrix lab = new LabyrinthMatrix(7, 7);
            lab.Matrix = matrixToTest01;

            LabyrinthRenderer renderer = new LabyrinthRenderer(player, lab);

            StringWriter writer = new StringWriter();

            using (writer)
            {
                Console.SetOut(writer);

                renderer.ConsoleDrawLabyrinth();

                string output = writer.ToString();

                Assert.AreEqual(expected, output);
            }
        }

        [TestMethod]
        public void TestLabyrintConsolePrintWithSecondMatrix()
        {
            char[,] matrixToTest02 = { 
               {'X','-','X','X','X','X','X'},
               {'X','-','X','X','X','X','X'},
               {'X','-','X','X','X','X','X'},
               {'X','-','-','-','-','-','X'},
               {'X','X','X','-','X','X','X'},
               {'X','X','X','X','X','X','X'},
               {'X','X','X','X','X','X','X'},
            };

            LabyrinthPlayer player = new LabyrinthPlayer(0, 1);
            LabyrinthMatrix lab = new LabyrinthMatrix(7, 7);
            lab.Matrix = matrixToTest02;
            LabyrinthRenderer renderer = new LabyrinthRenderer(player, lab);

            StringWriter writer = new StringWriter();
            string expected = String.Format(
                "{0}X*XXXXX{0}X-XXXXX{0}X-XXXXX{0}X-----X{0}XXX-XXX{0}XXXXXXX{0}XXXXXXX{0}",
                Environment.NewLine);

            using (writer)
            {
                Console.SetOut(writer);

                renderer.ConsoleDrawLabyrinth();

                string output = writer.ToString();

                Assert.AreEqual(expected, output);
            }
        }
    }
}
