using System;
using System.Collections;
using ObjectLogic.GameLogic;



namespace ObjectLogic.PlayerLogic
{
    public class PlayerModel
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime TimeOfCreation { get; set; }
        public int Points { get; set; }
        public ArrayList<Game> GamesPlayed { get; set; }
        public int RankingPosition { get; set; }

    }
}
