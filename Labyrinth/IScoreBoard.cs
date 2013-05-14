using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labyrinth
{
    public interface IScoreBoard
    {
        void HandleScoreboard(uint moveCount,string nickname);
        void ShowScoreboard();
    }
}
