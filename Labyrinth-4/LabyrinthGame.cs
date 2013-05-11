using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labyrinth
{
    class LabyrinthGame
    {
        static void Main(string[] args)
        {
            LabyrinthEngine engine = new LabyrinthEngine();

            while (true)
            {
                engine.ShowLabyrinth(engine.Matrix);
                engine.ShowInputMessage();
                engine.HandleInput();
            }
        }
    }
}
