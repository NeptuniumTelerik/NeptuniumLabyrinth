using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labyrinth
{
    public interface IPlayer
    {
        char PlayerSymbol { get; }
        int RowPosition { get; set; }
        int ColPosition { get; set; }
        uint MoveCounter { get; set; }
        void MoveDown();
        void MoveUp();
        void MoveRight();
        void MoveLeft();
    }
}
