using System;

namespace Labyrinth
{
    class LabyrinthPlayer
    {
        public readonly char playerSymbol = '*';

        private int rowPosition;
        private int colPosition;
        private uint moveCounter;
      
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

        public LabyrinthPlayer(int startRow, int startCol)
        {
            this.RowPosition = startRow;
            this.ColPosition = startCol;
            this.moveCounter = 0;
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

        public bool MoveLeft()
        {
            this.ColPosition--;
            this.moveCounter++;
            return true;
        }
    }
}
