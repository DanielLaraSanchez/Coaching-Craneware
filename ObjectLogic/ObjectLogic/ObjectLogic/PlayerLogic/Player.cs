using System;
using ObjectLogic.ValidatorLogic;
using ObjectLogic.GameLogic;
using System.Collections.Generic;

namespace ObjectLogic.PlayerLogic
{
    public class Player
    {


        public int ID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime TimeOfCreation { get; set; }
        public int Points { get; set; }
        public List<Game> GamesPlayed { get; set; }
        public int RankingPosition { get; set; }

        public Player(string name, string email)
        {
            Name = name;
            Email = email;
            TimeOfCreation = DateTime.Now;
            GamesPlayed = new List<Game>();

        }

        public void PlayGame(Player player1, Player player2)
        {
            Game game = new Game(player1, player2);
            SelectWinner(game, player1, player2);
            ActionOnPlayerAfterGame(game, player1, player2);
           
        }

        public void ConfirmGame(Game game, Validator validator, Player oponent)
        {
            validator.Validate(game, this, oponent);

        }



        public void SelectWinner(Game game, Player player1, Player player2)
        {
            Console.WriteLine("Who won?. ${player1.name} or {player2.name}?");
            var response = Console.ReadLine();

            if(player1.Name == response)
            {
                game.Winner = player1;

            }
            else if(player2.Name == response)
            {
                game.Winner = player2;
            }
            else
            {
                Console.WriteLine("You entered the wrong player. Focus please!");
            }

        }

        public void ActionOnPlayerAfterGame(Game game, Player player1, Player player2)
        {
            player1.GamesPlayed.Add(game);
            player2.GamesPlayed.Add(game);
        }


    }
}
