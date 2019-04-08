using System;
using System.Data.Entity;
using ObjectLogic.Player;

namespace ObjectLogic.GameLogic
{
    public class GameModel
    {
        public int ID { get; set; }
        public Player.Player player1  { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    
    }
}