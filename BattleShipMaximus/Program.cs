using System;
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

           var userInput = ReadKey();

    

            if (userInput.Key == ConsoleKey.Enter)
            {
                Clear();
                bool IsGameInPlay = true;

                do
                {

                    battleShipLogic.StartGame(battleShipLogic, gameFeedBackLogic, IsGameInPlay);
                }
                while (IsGameInPlay && battleShipLogic.ShotsRemaining != 0 || battleShipLogic.HitCount != 5);
              
            }

            if (userInput.Key == ConsoleKey.Escape)
            {
                Environment.Exit(-1);
            }
               
           
           
        }
    }
}
