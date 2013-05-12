using System;

namespace Labyrinth
{
    class LabyrinthGame
    {
        static void Main(string[] args)
        {
            LabyrinthEngine engine = new LabyrinthEngine();

            while (true)
            {
                engine.GameMenuControl();
            }
        }
    }
}
