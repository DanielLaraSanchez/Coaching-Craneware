using System;
using System.Collections.Generic;
using ObjectLogic.PlayerLogic;

namespace ObjectLogic.RankingLogic
{
    public class Ranking
    {
        public List<Player> PlayersRanking { get; set; }

        public Ranking()
        {
            PlayersRanking = new List<Player>();
        }

        public void AddNewPlayer(Player player)
        {
            PlayersRanking.Add(player);
        }




    }

  
}
