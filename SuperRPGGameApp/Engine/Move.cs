﻿using System;
namespace SuperRPGGameApp.Engine
{
    class Move
    {
        public static Position Hero { get; set; }

        public static void ExecuteCommand(ConsoleKeyInfo keyInfo)
        {
<<<<<<< HEAD
           
            
=======
            Map.PrintMap();
            Status.PrintStatus();
>>>>>>> e361981c8ad034c9971d16b7a3ec22b99d67c5a3
            Console.CursorVisible = false;
            InitGame();

            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        MoveHero(0, -1, Hero);
                        break;
                    case ConsoleKey.RightArrow:
                        MoveHero(1, 0, Hero);
                        break;
                    case ConsoleKey.DownArrow:
                        MoveHero(0, 1, Hero);
                        break;
                    case ConsoleKey.LeftArrow:
                        MoveHero(-1, 0, Hero);
                        break;
                }
            }
        }

        private static void MoveHero(int x, int y, Position newHero)
        {
            newHero = new Position()
            {
                X = Hero.X + x,
                Y = Hero.Y + y
            };

            if (CanMove(newHero))
            {
                RemoveHero();
                Console.SetCursorPosition(newHero.X, newHero.Y);

                Console.Write("♣");
                Hero = newHero;
            }
        }

        private static void RemoveHero()
        {
            Console.SetCursorPosition(Hero.X, Hero.Y);
            Console.Write(" ");
        }

        private static bool CanMove(Position c)
        {
            if (c.X < 1 || c.X >= 59)
                return false;
            if (c.Y < 1 || c.Y >= 21)
                return false;
            return true;
        }

        private static void InitGame()
        {
            Hero = new Position()
            {
                X = 1,
                Y = 1
            };
            MoveHero(0, 0, Hero);
        }
    }
}
