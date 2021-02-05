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
                WriteLine("           If yes, press enter to continue.");
                WriteLine("           Otherwise press escape to exit the program and close this window.");


              
            }
        }

        public void ShowGrid()
        {

            var endGameButton = ReadKey();
            var startGameButton = ReadKey();

            if (startGameButton.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("  Let the battle begin!");
                Console.WriteLine("         10 + + + + + + + + + +");
                Console.WriteLine("          9 + + + + + + + + + +");
                Console.WriteLine("          8 + + + + + + + + + +");
                Console.WriteLine("          7 + + + + + + + + + +");
                Console.WriteLine("          6 + + + + + + + + + +");
                Console.WriteLine("          5 + + + + + + + + + +");
                Console.WriteLine("          4 + + + + + + + + + +");
                Console.WriteLine("          3 + + + + + + + + + +");
                Console.WriteLine("          2 + + + + + + + + + +");
                Console.WriteLine("          1 + + + + + + + + + +");
                Console.WriteLine("          0 1 2 3 4 5 6 7 8 9 10\n");
            }

                if (endGameButton.Key == ConsoleKey.Escape)
            {
                //exit program
                System.Environment.Exit(0);
            }
     
        }

        public void YouHitTheShip(int hitsRemaining)
        {
            WriteLine("Nice shot! Direct hit!");
            WriteLine();
            WriteLine("You need " + hitsRemaining + "to sink her.");
        }

        public void YouMissedTheShip()
        {
            WriteLine("Tough luck. She's a wily one. You missed her!");
        }

        public void YouSunkTheShip()
        {
            WriteLine("Excellent finish! She's going down! Deploy life raft and rescue personel.");
            WriteLine();
            WriteLine("The day is yours! You've won the game!");
        }

        public void NoMoreAmmo()
        {
            WriteLine("Alas! You're out of ammo. Set a course to take us out of range!");
            WriteLine();
            WriteLine("GAME OVER");
        }
    }
}
