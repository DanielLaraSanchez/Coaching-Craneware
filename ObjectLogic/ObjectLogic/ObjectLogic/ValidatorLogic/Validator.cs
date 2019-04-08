using System;
using ObjectLogic.GameLogic;
using ObjectLogic.Interfaces;
using ObjectLogic.PlayerLogic;


namespace ObjectLogic.ValidatorLogic
{
    public class Validator : IValidator
    {
        public Validator()
        {
        }

        public string Validate(Game game, Player looser, Player winner)
        {
            if (game.Winner.ID != looser.ID)
            {
                game.MarkConfirmed();
                ActionUponGame(game, looser, winner);
                return "game has been confirmed";
            }
            else
            {
                return "you cant confirm  this game";
            }

        }

        public void ActionUponGame(Game game, Player looser, Player winner)
        {
            winner.Points += 2;

            if (looser.Points >= 2)
            {
                looser.Points -= 2;
            }
            else
            {
                looser.Points = 0;
            }
        }




    }
}
