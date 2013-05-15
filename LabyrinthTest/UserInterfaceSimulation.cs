using System;
using Labyrinth;

namespace LabyrinthGameProjectTest
{
    public class UserInterfaceSimulation:LabyrinthEngine
    {
        private string simulateInput = "";

        public string SimulateInput
        {
            get { return simulateInput; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    simulateInput = value;
                }
                else
                {
                    throw new ArgumentNullException("Input is null");
                }
            }
        }

        private bool simulateWin = false;

        public bool SimulateWin
        {
            get { return simulateWin; }

            set
            {
                if (value != null)
                {
                    simulateWin = value;
                }
                else
                {
                    throw new AccessViolationException("Input is null");
                }
            }
        }

        private int steps = 0;

        public override string ProcessInput()
        {
            string output = this.SimulateInput;
            if (!simulateWin)
            {
                this.SimulateInput = "exit";
            }
            else
            {
                this.steps++;
                if (this.steps == 3)
                {
                    this.SimulateInput = "exit";
                }
            }

            return output;
        }
    }
}
