using System;
using snake.Objects;
namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(20, 10);
            game.Render();
        }
    }
}
