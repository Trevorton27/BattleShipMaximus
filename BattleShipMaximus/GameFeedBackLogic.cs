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
            WriteLine();
            WriteLine("           Hey there. Welcome to the classic game of Battle Ship.");
            WriteLine();
            WriteLine("           Press Enter to continue");
        }

        public void GameExplanation()
        {
            var button = ReadKey();
            if (button.Key == ConsoleKey.Enter)
            {
                WriteLine();
                WriteLine("           Here's how it works.");
                WriteLine();
                WriteLine("          ***********************************************");
                WriteLine("           You have 8 shells to fire at the Battle Ship.");
                WriteLine();
                WriteLine("           You must hit the Battle Ship 5 times to sink it.");
                WriteLine("        ************************************************");
                WriteLine();
                WriteLine("           Are you ready?");
                WriteLine();
                WriteLine("           If yes, press enter and let the battle begin!");
                WriteLine("           Otherwise press escape to exit the program.");



            }
        }

        

        public void YouHitTheShip(int hitsRemaining, int shotsRemaining)
        {
            WriteLine();
            WriteLine("           Nice shot! Direct hit!");

            WriteLine("           You have " + shotsRemaining + " shells remaining in the armory.");
            WriteLine();
            WriteLine("           You need " + hitsRemaining + " more to sink her. Fire at will");

        }

        public void YouMissedTheShip(int hitsRemaining, int shotsRemaining)
        {
            WriteLine();
            WriteLine("           Tough luck. She's a wily one. You missed her!");
            WriteLine();
            WriteLine("            You need to hit her " + hitsRemaining + " more times to sink her");
            WriteLine();
            WriteLine("           You have " + shotsRemaining + " shells remaining in the armory. Make em count sailor!");

        }

        public void YouSunkTheShip(int hitsRemaining, int shotsRemaining)
        {
            WriteLine();
            WriteLine("           Hits remaining: " + hitsRemaining + " Shots remaining: " + shotsRemaining);
            WriteLine("           Excellent finish! She's going down! Deploy life raft and rescue personel.");
            WriteLine();
            WriteLine("           The day is yours! You've won the game!");
            WriteLine();
            WriteLine("           Play again? Press ENTER to play again or ESC to quit.");
        }

        public void NoMoreAmmo(int hitsRemaining, int shotsRemaining)
        {
            Clear();
                WriteLine();
                WriteLine();
                WriteLine("           Alas! You missed her and you have " + shotsRemaining + " shots remaining. You're out of ammo.");
            WriteLine("                                     Set a course to take us out of range!");

            WriteLine();
                WriteLine("                                             GAME OVER");
            WriteLine();
            WriteLine();
            WriteLine("                         Press ENTER to play again, if ye dare or ESC to quit.");

        }

        public void GameRestarted(int hitsRemaining, int shotsRemaining)
        {
            Clear();
            WriteLine();
            WriteLine("           Excellent choice, private! Way to get back in the fight! You have " + hitsRemaining + " hits and " + shotsRemaining + "  hots remaining.");
            WriteLine();
            WriteLine("           Make em count, soldier!");
            WriteLine();
        }

        public void GameEnded()
        {
            WriteLine();
            WriteLine("           Thank you for your service, soldier.");
            WriteLine();
        }
           
    }
}
