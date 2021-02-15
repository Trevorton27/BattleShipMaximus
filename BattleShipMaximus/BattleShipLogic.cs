using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace BattleShipMaximus
{
    class BattleShipLogic
    {

        public int HitCount = 0;

        public int ShotsRemaining = 1;

        public int X_axis { get; set; }
        public int Y_axis { get; set; }


        public BattleShipLogic()
        {
            SetPosition();

        }
        public void SetPosition()
        {
            var placeBattleShip = new Random();

            X_axis = 5; //placeBattleShip.Next(1, 10);
            Y_axis = 5; //placeBattleShip.Next(1, 10);
        }

        public int GetPlayerXAxis()
        {
            WriteLine("           Enter an X coordinate from 1 to 10.");
            var Xcoordinate = int.TryParse(ReadLine(), out int userChoice);
            if (userChoice < 1 || userChoice > 10 || Xcoordinate == false)
                while (Xcoordinate == false)
                {
                    WriteLine("           That coordinate could result in friendly fire. Do not proceed!");
                    Console.WriteLine("           Enter a valid X coordinate from 1 to 10");
                    Xcoordinate = int.TryParse(Console.ReadLine(), out userChoice);
                }

            return userChoice;
        }

        public int GetPlayerYAxis()
        {
            WriteLine("           Enter an Y coordinate from 1 to 10.");
            var Ycoordinate = int.TryParse(ReadLine(), out int userChoice);
            if (userChoice < 1 || userChoice > 10 || Ycoordinate == false)
                while (Ycoordinate == false)
                {
                    WriteLine("           That coordinate could result in friendly fire. Do not proceed!");
                    Console.WriteLine("           Enter a valid Y coordinate from 1 to 10");
                    Ycoordinate = int.TryParse(Console.ReadLine(), out userChoice);
                }

            return userChoice;
        }

        public bool FireShot(int x, int y)
        {
            var isAHit = x == X_axis && y == Y_axis;

            if (isAHit)
            {
                HitCount++;
            }

            return isAHit;
        }

        public bool ShipIsSunk()
        {
            return HitCount >= 5;
        }


      
        public void ShowGrid()
        {

            WriteLine("                 *********************************");
            WriteLine();
            WriteLine("                     10 + + + + + + + + + +");
            WriteLine("                      9 + + + + + + + + + +");
            WriteLine("                      8 + + + + + + + + + +");
            WriteLine("                      7 + + + + + + + + + +");
            WriteLine("                      6 + + + + + + + + + +");
            WriteLine("                      5 + + + + + + + + + +");
            WriteLine("                      4 + + + + + + + + + +");
            WriteLine("                      3 + + + + + + + + + +");
            WriteLine("                      2 + + + + + + + + + +");
            WriteLine("                      1 + + + + + + + + + +");
            WriteLine("                      0 1 2 3 4 5 6 7 8 9 10\n");
            WriteLine();
            WriteLine("                 *********************************");
        }

        public void StartGame(BattleShipLogic battleShipLogic, GameFeedBackLogic gameFeedBackLogic, bool IsGameInPlay)
        {
            battleShipLogic.ShowGrid();
            var Xaxis = battleShipLogic.GetPlayerXAxis();
            var Yaxis = battleShipLogic.GetPlayerYAxis();

            var IsTheShipHit = battleShipLogic.FireShot(Xaxis, Yaxis);

            void ReStartOrEndGame()
            {
                var ReStartGame = ReadKey();
                var EndGame = ReadKey();

                if (ReStartGame.Key == ConsoleKey.Enter)
                {
                    battleShipLogic.HitCount = 0;
                    battleShipLogic.ShotsRemaining = 8;

                    battleShipLogic.SetPosition();
                    gameFeedBackLogic.GameRestarted(battleShipLogic.HitCount, battleShipLogic.ShotsRemaining);
                    StartGame( battleShipLogic,  gameFeedBackLogic,  IsGameInPlay);
                }

                if (EndGame.Key == ConsoleKey.Escape)
                {
                    gameFeedBackLogic.GameEnded();
                    Environment.Exit(-1);
                }
            }

          
            if (!IsTheShipHit && battleShipLogic.ShotsRemaining == 0)
            {
                gameFeedBackLogic.NoMoreAmmo(5 - battleShipLogic.HitCount, battleShipLogic.ShotsRemaining);
                ReStartOrEndGame();
            }
            if (IsTheShipHit && battleShipLogic.ShipIsSunk() == false)
            {
                Clear();
                gameFeedBackLogic.YouHitTheShip(5 - battleShipLogic.HitCount, --battleShipLogic.ShotsRemaining);
                battleShipLogic.SetPosition();
                StartGame(battleShipLogic, gameFeedBackLogic, IsGameInPlay);
            }
            if (IsTheShipHit == false && battleShipLogic.ShipIsSunk() == false)
            {
                Clear();
                gameFeedBackLogic.YouMissedTheShip(5 - battleShipLogic.HitCount, --battleShipLogic.ShotsRemaining);
                WriteLine();

            }

            if (battleShipLogic.ShipIsSunk() == true && battleShipLogic.HitCount == 5)
            {
                Clear();
                gameFeedBackLogic.YouSunkTheShip(5 - battleShipLogic.HitCount, --battleShipLogic.ShotsRemaining);

                ReStartOrEndGame();
            }
           
        }
    }

}

