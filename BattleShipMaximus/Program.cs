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

            var startGameButton = ReadKey();
            bool IsGameInPlay = true;
            if (startGameButton.Key == ConsoleKey.Enter)
            {
                while (IsGameInPlay)
                {

                    battleShipLogic.ShowGrid();
                    var Xaxis = battleShipLogic.GetPlayerXAxis();
                    var Yaxis = battleShipLogic.GetPlayerYAxis();

                    var IsTheShipHit = battleShipLogic.FireShot(Xaxis, Yaxis);

                    if (IsTheShipHit)
                    {
                        gameFeedBackLogic.YouHitTheShip(5 - battleShipLogic.HitCount);
                        battleShipLogic.SetPosition();
                    }
                    if(!IsTheShipHit)
                    {
                        gameFeedBackLogic.YouMissedTheShip();
                        WriteLine("I don't really do anything.");
                    }

                    if (battleShipLogic.ShipIsSunk() == true)
                    {
                        gameFeedBackLogic.YouSunkTheShip();
                        IsGameInPlay = false;
                        if(IsGameInPlay == false)
                        {
                            WriteLine("Play again? Press ENTER to play again or ESC to quit.");
                        }
                    }
                }
            }
               
           
        }
    }
}
