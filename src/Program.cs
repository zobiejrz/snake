using System;
using snake.Objects;

// This program will run the sort of crappy version in the terminal

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.Render();
            string lastMove = "";
            while (game.IsNotDead)
            {
                Console.Write("MOVE [ a | s | d | w ] >>> ");
                string move = Console.ReadLine();
                bool valid = (move == "a" && lastMove != "d") || (move == "s" && lastMove != "w") || (move == "d" && lastMove != "a") || (move == "w" && lastMove != "s");

                if (valid)
                {
                    switch (move)
                    {
                        case "a":
                            game.TakeStep(Game.Direction.Left);
                            break;
                        case "s":
                            game.TakeStep(Game.Direction.Down);
                            break;
                        case "d":
                            game.TakeStep(Game.Direction.Right);
                            break;
                        case "w":
                            game.TakeStep(Game.Direction.Up);
                            break;
                    }
                    lastMove = move;
                }
                else
                {
                    Console.WriteLine("Can't go the way you came!");
                }


            }

            Console.WriteLine($"GAME OVER.\nFINAL SCORE: {game.Score}");

        }
    }
}
