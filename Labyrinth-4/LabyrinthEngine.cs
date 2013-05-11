using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labyrinth
{
    public class LabyrinthEngine
    {
        private LabyrinthMatrix matrix;
        private uint moveCount;
        private TopFiveScoreboard scoreboard;

        public LabyrinthMatrix Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        public LabyrinthEngine()
        {
            scoreboard = new TopFiveScoreboard();
            Restart();
        }

        public void ShowInputMessage()
        {
            Console.Write("Enter your move (L=left, R-right, U=up, D=down): ");
        }

        public void HandleInput()
        {
            string input = Console.ReadLine();
            string lowerInput = input.ToLower();

            switch(lowerInput)
            {
                case "l": moveLeft();break;
                case "r": moveRight();break;
                case "u":moveUp();break;
                case "d":moveDown();break;
                case "top":scoreboard.ShowScoreboard();break;
                case "restart": Restart(); break;
                case "exit":Console.WriteLine("Good bye!");System.Environment.Exit(0); break;
                default: Console.WriteLine("Invalid command!"); break;
            }

            IsFinished();
        }

        public  void ShowLabyrinth(LabyrinthMatrix labyrinth)
        {
            Console.WriteLine();
            char[,] myMatrix = labyrinth.Matrix;
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    if (i == labyrinth.MyPostionVertical && j == labyrinth.MyPostionHorizontal)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(myMatrix[j, i]);
                    }
                }
                Console.WriteLine();
            }
        }

        private void IsFinished()
        {
            int posHorizontal = matrix.MyPostionHorizontal;
            int posVertical = matrix.MyPostionVertical;
            if (posHorizontal == 0 || posHorizontal == 6 ||posVertical == 0 || posVertical == 6)
            {
                Console.WriteLine("Congratulations! You escaped in " + moveCount + " moves.");
                scoreboard.HandleScoreboard(moveCount);
                Restart();
            }
        }

        private void Restart()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to “Labirinth” game. Please try to escape. Use 'top' to view the top scoreboard, 'restart' to start a new game and 'exit' to quit the game.");
            this.matrix = new LabyrinthMatrix();
            moveCount = 0;
        }

        private void moveDown()
        {
            int posHorizontal = matrix.MyPostionHorizontal;
            int posVertical = matrix.MyPostionVertical;
            if (posVertical != 6 && this.matrix.Matrix[posHorizontal, posVertical + 1] == '-')
            {
                matrix.MyPostionVertical++;
                moveCount++;
                return ;
            }
            Console.WriteLine("Invalid move!");
            
        }

        private void moveUp()
        {
            int posHorizontal = matrix.MyPostionHorizontal;
            int posVertical = matrix.MyPostionVertical;
            if (posVertical != 0 && this.matrix.Matrix[posHorizontal, posVertical - 1] == '-')
            {
                matrix.MyPostionVertical--;
                moveCount++;
                return;
            }
            Console.WriteLine("Invalid move!");

        }

        private void moveRight()
        {
            int posHorizontal = matrix.MyPostionHorizontal;
            int posVertical = matrix.MyPostionVertical;
            if (posHorizontal != 6 && this.matrix.Matrix[posHorizontal + 1, posVertical] == '-')
            {
                matrix.MyPostionHorizontal++;
                moveCount++;
                return;
            }
            Console.WriteLine("Invalid move!");
        }

        private void moveLeft()
        {
            int posHorizontal = matrix.MyPostionHorizontal;
            int posVertical = matrix.MyPostionVertical;
            if (posHorizontal != 0 && this.matrix.Matrix[posHorizontal - 1, posVertical] == '-')
            {
                matrix.MyPostionHorizontal--;
                moveCount++;
                return;
            }
            Console.WriteLine("Invalid move!");
        }
    }
}
