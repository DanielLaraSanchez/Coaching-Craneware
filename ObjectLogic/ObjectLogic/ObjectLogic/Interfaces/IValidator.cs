using System;
using ObjectLogic.GameLogic;
using ObjectLogic.PlayerLogic;


namespace ObjectLogic.Interfaces
{
    public interface IValidator
    {
        string Validate(Game game, Player looser, Player winner);
    }
}
