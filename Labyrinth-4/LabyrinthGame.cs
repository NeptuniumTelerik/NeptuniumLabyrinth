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
            LabyrinthEngine processor = new LabyrinthEngine();

            while (true)
            {
                LabyrinthEngine.ShowLabyrinth(processor.Matrix);
                processor.ShowInputMessage();
                string input = Console.ReadLine();
                processor.HandleInput(input);
            }
        }
    }
}
