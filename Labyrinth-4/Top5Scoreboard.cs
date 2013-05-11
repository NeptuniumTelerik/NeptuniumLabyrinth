using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labyrinth
{
    public class Top5Scoreboard
    {
        private List<Tuple<uint, String>> scoreboard;

        public Top5Scoreboard()
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
            else if (this.scoreboard.Count == 0 ||(this.scoreboard.Count < 5) && this.scoreboard.Last().Item1 < moveCount)
            {
                string nickname = ShowScoreboardInMessage();
                scoreboard.Add(new Tuple<uint, string>(moveCount, nickname));
                this.ShowScoreboard();
                return;
            }

            for (int i = 0; i < scoreboard.Count(); ++i)
            {
                if (moveCount <= scoreboard[i].Item1)
                {
                    string nickname = ShowScoreboardInMessage();
                    scoreboard.Insert(i, new Tuple<uint, string>(moveCount, nickname));
                    if (scoreboard.Count > 5)
                    {
                        scoreboard.Remove(scoreboard.Last());
                    }
                    this.ShowScoreboard();
                    break;
                }
            }
        }

        private string ShowScoreboardInMessage()
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
