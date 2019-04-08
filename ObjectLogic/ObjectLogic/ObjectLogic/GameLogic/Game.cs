using System;
using ObjectLogic.PlayerLogic;

namespace ObjectLogic.GameLogic
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Player Winner { get; set; }
        public DateTime Time { get; set; }
        public bool HasBeenPlayed { get; set; }
        public bool HasBeenConfirmed { get; set; }


        public Game(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
            Time = DateTime.Now;
            HasBeenPlayed = false;
            HasBeenConfirmed = false;
        }

        public void MarkConfirmed()
        {
            this.HasBeenConfirmed = true;
            this.HasBeenPlayed = true;
        }

    }
}
