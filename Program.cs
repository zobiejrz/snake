using System;
using System.Threading;
using snake.Objects;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            // CIRCLE
            for (int i = 0; i < 12; i++)
            {
                Game.Direction d;
                if (i < 3)
                {
                    d = Game.Direction.LEFT;
                }
                else if (i < 6)
                {
                    d = Game.Direction.DOWN;
                }
                else if (i < 9)
                {
                    d = Game.Direction.RIGHT;
                }
                else
                {
                    d = Game.Direction.UP;
                }

                game.TakeStep(d);
                if (d == Game.Direction.RIGHT)
                {
                    game.Feed();

                }
                
            }
        }
    }
}
