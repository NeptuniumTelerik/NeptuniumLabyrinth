using System;

namespace Labyrinth
{
   public class LabyrinthGame
    {
      public  static void Main()
        {
            LabyrinthEngine engine = new LabyrinthEngine();

            while (true)
            {
                engine.GameMenuControl();
            }
        }
    }
}
