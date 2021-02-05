using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace BattleShipMaximus
{
    class BattleShipLogic
    {


        public int HitCount { get; set; }
        public int X_axis { get; set; }
        public int Y_axis { get; set; }


        public BattleShipLogic()
        {
            SetPosition();

        }
        public void SetPosition()
        {
            var placeBattleShip = new Random();
            X_axis = placeBattleShip.Next(1, 10);
            Y_axis = placeBattleShip.Next(1, 10);
            //  Console.WriteLine("Im working");
        }

    

        public void ShowGrid()
        {
            Clear();
            WriteLine("         ************************");
            WriteLine("           Let the battle begin!");
            WriteLine("         ************************");
            WriteLine();
            WriteLine("         10 + + + + + + + + + +");
            WriteLine("          9 + + + + + + + + + +");
            WriteLine("          8 + + + + + + + + + +");
            WriteLine("          7 + + + + + + + + + +");
            WriteLine("          6 + + + + + + + + + +");
            WriteLine("          5 + + + + + + + + + +");
            WriteLine("          4 + + + + + + + + + +");
            WriteLine("          3 + + + + + + + + + +");
            WriteLine("          2 + + + + + + + + + +");
            WriteLine("          1 + + + + + + + + + +");
            WriteLine("          0 1 2 3 4 5 6 7 8 9 10\n");
            WriteLine();
            WriteLine("         ************************");
        }

        public int GetPlayerXAxis()
        {
            WriteLine("           Enter an X coordinate from 1 to 10.");
            var Xcoordinate = int.TryParse(ReadLine(), out int userChoice);
            if (userChoice < 1 || userChoice > 10 || Xcoordinate == false)
                while (Xcoordinate == false)
                {
                    WriteLine("           That coordinate could result in friendly fire. Do not proceed!");
                    Console.WriteLine("           Enter a valide X coordinate from 1 to 10");
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
                    Console.WriteLine("           Enter a valide Y coordinate from 1 to 10");
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

            //Console.Write("Im working too");
            return isAHit;
        }

        public bool ShipIsSunk()
        {
            return HitCount >= 5;
        }
    
    }
}
