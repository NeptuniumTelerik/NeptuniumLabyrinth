using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labyrinth
{
    public class TopFiveScoreboard:IScoreBoard
    {
        private List<Tuple<uint, string>> scoreboard;

        public List<Tuple<uint, string>> Scoreboard
        {
            get { return this.scoreboard; }
            private set { this.scoreboard = value; }
        }

        public TopFiveScoreboard()
        {
            this.Scoreboard = new List<Tuple<uint, string>>();
        }

        public void HandleScoreboard(uint moveCount, string nickname)
        {
            if (this.Scoreboard.Count >= 5 && moveCount > this.Scoreboard.Last().Item1)
            {
                Console.WriteLine("You are not good enough for the scoreboard :)");
                return;
            }
            else if (this.Scoreboard.Count == 0 || (this.Scoreboard.Count < 5 && this.Scoreboard.Last().Item1 < moveCount))
            {
                Scoreboard.Add(new Tuple<uint, string>(moveCount, nickname));
                this.ShowScoreboard();
                return;
            }

			SortTopPlayers(moveCount,nickname);
        }

		private void SortTopPlayers(uint moveCount,string nickname)
		{
            for (int i = 0; i < this.Scoreboard.Count; ++i)
			{
                if (moveCount <= this.Scoreboard[i].Item1)
				{
                    this.Scoreboard.Insert(i, new Tuple<uint, string>(moveCount, nickname));
                    if (this.Scoreboard.Count > 5)
					{
                        Scoreboard.Remove(Scoreboard.Last());
					}

					this.ShowScoreboard();
					break;
				}
			}
		}

        public void ShowScoreboard()
        {
            if (this.Scoreboard.Count == 0)
            {
                Console.WriteLine("The scoreboard is empty.");
                return;
            }

            for (int i = 0; i < this.Scoreboard.Count; ++i)
            {
                Console.WriteLine((i + 1) + ". " + this.Scoreboard[i].Item2 + " --> " + this.Scoreboard[i].Item1 + " moves.");
            }
        }
    }
}
