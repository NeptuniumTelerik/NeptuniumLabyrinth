using System;

namespace Labyrinth
{
  public  class LabyrinthPlayer:IPlayer
    {
        private int rowPosition;
        private int colPosition;
        private uint moveCounter;
        private char playerSymbol = '*';  

        public int RowPosition
        {
            get { return this.rowPosition; }
            set { this.rowPosition = value; }
        }

        public int ColPosition
        {
            get { return this.colPosition; }
            set { this.colPosition = value; }
        }

        public uint MoveCounter
        {
            get { return this.moveCounter; }
            set { this.moveCounter = value; }
        }

        public char PlayerSymbol
        {
            get { return this.playerSymbol; }
            private set { this.playerSymbol = value; }
        }

        public LabyrinthPlayer(int startRow, int startCol, char symbol = '*')
        {
            this.RowPosition = startRow;
            this.ColPosition = startCol;
            this.MoveCounter = 0;
            this.PlayerSymbol = symbol;
        }

        //Player Movement Implementation

        public void MoveDown()
        {
            this.RowPosition++;
            this.moveCounter++;
        }

        public void MoveUp()
        {
            this.RowPosition--;
            this.moveCounter++;
        }

        public void MoveRight()
        {
            this.ColPosition++;
            this.moveCounter++;
        }

        public void MoveLeft()
        {
            this.ColPosition--;
            this.moveCounter++;
        }
    }
}
