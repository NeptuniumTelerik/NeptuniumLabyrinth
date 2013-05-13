using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labyrinth
{
    public class TopFiveScoreboard
    {
        private List<Tuple<uint, String>> scoreboard;

        public TopFiveScoreboard()
        {
            this.scoreboard = new List<Tuple<uint, string>>();
        }

        public void HandleScoreboard(uint moveCount)
        {
            if (this.scoreboard.Count >= 5 && moveCount > this.scoreboard.Last().Item1)
            {
                Console.WriteLine("You are not good enough for the scoreboard :)");
                return;
            }
            else if ( this.scoreboard.Count == 0 ||(this.scoreboard.Count < 5 && this.scoreboard.Last().Item1 < moveCount))
            {
                string nickname = ShowScoreboardInputMessage();
                scoreboard.Add(new Tuple<uint, string>(moveCount, nickname));
                this.ShowScoreboard();
                return;
            }

			SortTopPlayers(moveCount);
        }

		private void SortTopPlayers(uint moveCount)
		{
			for (int i = 0; i < this.scoreboard.Count; ++i)
			{
				if (moveCount <= this.scoreboard[i].Item1)
				{
					string nickname = ShowScoreboardInputMessage();
					this.scoreboard.Insert(i, new Tuple<uint, string>(moveCount, nickname));
					if (scoreboard.Count > 5)
					{
						scoreboard.Remove(scoreboard.Last());
					}

					this.ShowScoreboard();
					break;
				}
			}
		}


        private string ShowScoreboardInputMessage()
        {
            Console.Write("Please enter your name for the top scoreboard: ");
            string nickname = Console.ReadLine();
            return nickname;
        }

        public void ShowScoreboard()
        {
            if (scoreboard.Count == 0)
            {
                Console.WriteLine("The scoreboard is empty.");
                return;
            }

            for (int i = 0; i < scoreboard.Count; ++i)
            {
                Console.WriteLine((i+1) + ". " + scoreboard[i].Item2 + " --> " + scoreboard[i].Item1 + " moves.");
            }
        }
    }
}
