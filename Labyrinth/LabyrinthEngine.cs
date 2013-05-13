using System;

namespace Labyrinth
{
    public class LabyrinthEngine
    {
        
        private TopFiveScoreboard scoreboard;
        private LabyrinthPlayer player;
        private LabyrinthMatrix labyrinth;

        public LabyrinthEngine()
        {
            this.scoreboard = new TopFiveScoreboard();
        }

        private void Start(int maxRows,int maxCols)
        {
            this.player = new LabyrinthPlayer(maxRows/2, maxCols/2);
            this.labyrinth = new LabyrinthMatrix(maxRows, maxCols);
            this.labyrinth.GenerateLabyrinthMatrix();

            while (true)
            {
                DrawLabyrinth();

                if (IsFinished())
                {
                    break;
                }

                PlayerControl();
            }
        }

        public void GameMenuControl()
        {
            Console.WriteLine(Environment.NewLine +
               "Welcome to “Labirinth” game. Please try to escape.\n" +
               "Commands:\n'TOP' to view the top scoreboard\n'START' to start a new game" +
               "\n'EXIT' to quit the game");

            string input = ProcessInput();

			int matrixSize = 7;

            switch (input)
            {
                case "top": scoreboard.ShowScoreboard(); break;
				case "start": Start(matrixSize, matrixSize); break;
                case "exit": Console.WriteLine("Good bye!"); System.Environment.Exit(0); break;
                default: Console.WriteLine("Invalid command!"); break;
            }

        }

        public void PlayerControl()
        {
            Console.Write("Enter your move (L=left, R-right, U=up, D=down): ");
            string input = ProcessInput();

            bool commandExecuted = MovePlayer(input);

            if (!commandExecuted)
            {
                Console.WriteLine("Invalid Move !");
            }
        }

        public bool MovePlayer(string value)
        {
            switch (value)
            {
                case "l":
                    if(this.labyrinth.IsPassable(this.player.RowPosition,this.player.ColPosition - 1))
                    {
                        this.player.MoveLeft();
                        return true;
                    }
                    break;
                case "r":
                    if(this.labyrinth.IsPassable(this.player.RowPosition,this.player.ColPosition + 1))
                    {
                        this.player.MoveRight();
                        return true;
                    }
                    break;
                case "u":
                     if(this.labyrinth.IsPassable(this.player.RowPosition - 1,this.player.ColPosition))
                    {
                        this.player.MoveUp();
                        return true;
                    }
                     break;
                case "d":
                     if(this.labyrinth.IsPassable(this.player.RowPosition + 1,this.player.ColPosition))
                    {
                        this.player.MoveDown();
                        return true;
                    }
                     break;
            }
            return false;
        }

        public string ProcessInput()
        {
            string input = Console.ReadLine();
            string lowerInput = input.ToLower();
            return lowerInput;
        }

        private bool IsFinished()
        {
            bool isOutsideLabyrinth = this.labyrinth.isOutsideMatrix(this.player.RowPosition,this.player.ColPosition);
            if (isOutsideLabyrinth)
            {
                Console.WriteLine("Congratulations! You escaped in " + this.player.MoveCounter + " moves.");
                scoreboard.HandleScoreboard(this.player.MoveCounter);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DrawLabyrinth()
        {
            char[,] matrix = this.labyrinth.Matrix;

            Console.WriteLine();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == this.player.RowPosition && col == this.player.ColPosition)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(this.player.playerSymbol);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.Write(matrix[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
