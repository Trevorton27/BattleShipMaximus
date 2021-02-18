﻿using System;
using static System.Console;

namespace BattleShipMaximus
{
    class Program
    {
        static void Main(string[] args)
        {
            var battleShipLogic = new BattleShipLogic();
            var gameFeedBackLogic = new GameFeedBackLogic();

            gameFeedBackLogic.WelcomeMessage();
            gameFeedBackLogic.GameExplanation();

            var startGameButton = ReadKey();
            var endGameButton = ReadKey();

            bool IsGameInPlay = true;
            if (startGameButton.Key == ConsoleKey.Enter)
            {
                while (IsGameInPlay && battleShipLogic.ShotsRemaining != 0 || battleShipLogic.HitCount != 5)
                {

                    battleShipLogic.StartGame(battleShipLogic, gameFeedBackLogic, IsGameInPlay);
                }
            }

            if (endGameButton.Key == ConsoleKey.Escape)
            {
                Environment.Exit(-1);
            }
               
           
           
        }
    }
}
