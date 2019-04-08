using System;
using ObjectLogic.ValidatorLogic;
using ObjectLogic.GameLogic;
using System.Collections.Generic;
using ObjectLogic.PlayerLogic;

namespace ObjectLogic
{
    class Program
    {
        static void Main(string[] args)
        {
             Player player1 = new Player("Daniel", "Daniel@hotmail.com");
             Player player2 = new Player("James", "j.illing@hotmail.com");

            player1.PlayGame(player1, player2);
            Console.WriteLine(player1.Email);
    }
    }
}
