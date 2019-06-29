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
            
            for (int i = 0; i < 100; i++)
            {
                game.TakeStep(Game.Direction.DOWN);
            }
            
            
            
        }
    }
}
