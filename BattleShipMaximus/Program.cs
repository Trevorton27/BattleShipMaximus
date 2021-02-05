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
            string input = ReadLine();

            bool IsGameInPlay = true;
            if (startGameButton.Key == ConsoleKey.Enter)
            {
                while (IsGameInPlay)
                {

                    battleShipLogic.StartGame(battleShipLogic, gameFeedBackLogic, IsGameInPlay);
                }
            }
               
           
           
        }
    }
}
