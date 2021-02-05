using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace BattleShipMaximus
{
    class GameFeedBackLogic
    {

        public void WelcomeMessage()
        {
            WriteLine("           Hey there. Welcome to the classic game of Battle Ship.");
            WriteLine();
            WriteLine("           Press Enter to continue");
        }

        public void GameExplanation()
        {
            var button = ReadKey();
            if (button.Key == ConsoleKey.Enter)
            {
                WriteLine("           You have 8 missiles to fire at the Battle Ship.");
                WriteLine();
                WriteLine("           You must hit the Battle Ship 5 times to sink it.");
                WriteLine();
                WriteLine("           Are you ready?");
                WriteLine();
                WriteLine("           If yes, press enter and let the battle begin!");
                WriteLine("           Otherwise press escape to exit the program and close this window.");


              
            }
        }


        public void YouHitTheShip(int hitsRemaining)
        {
            WriteLine("           Nice shot! Direct hit!");
            WriteLine();
            WriteLine("           You need " + hitsRemaining + "to sink her.");
        }

        public void YouMissedTheShip()
        {
            WriteLine("           Tough luck. She's a wily one. You missed her!");
        }

        public void YouSunkTheShip()
        {
            WriteLine("           Excellent finish! She's going down! Deploy life raft and rescue personel.");
            WriteLine();
            WriteLine("           The day is yours! You've won the game!");
        }

        public void NoMoreAmmo()
        {
            WriteLine("           Alas! You're out of ammo. Set a course to take us out of range!");
            WriteLine();
            WriteLine("                                 GAME OVER");
        }
    }
}
