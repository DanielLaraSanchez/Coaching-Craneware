using System;
using System.Data.Entity;
using ObjectLogic.PlayerLogic;


namespace ObjectLogic.GameLogic
{
    public class GameModel
    {
        public int ID { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Player Winner { get; set; }
        public DateTime Time { get; set; }
        public bool HasBeenPlayed { get; set; }
        public bool HasBeenConfirmed { get; set; }
    }
}
