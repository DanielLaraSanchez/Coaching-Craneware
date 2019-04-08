using System;
using System.Collections;

using ObjectLogic.ValidatorLogic;
using ObjectLogic.GameLogic;
using ObjectLogic.Interfaces;



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
        public Game[] GamesPlayed { get; set; }
        public int RankingPosition { get; set; }

        public Player(string name, string email)
        {
            Name = name;
            Email = email;
            TimeOfCreation = DateTime.Now;
            GamesPlayed = new ArrayList();

        }

        public void PlayGame(Player player1, Player player2)
        {
            Game game = new Game(player1, player2);
            player1.GamesPlayed.

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


    }
}
