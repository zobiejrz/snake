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
            game.Render();
            
            game.player.TakeStep(Game.Direction.RIGHT);
            game.Render();
            Thread.Sleep(250);
            game.player.TakeStep(Game.Direction.RIGHT);
            game.Render();
            Thread.Sleep(250);
            game.player.TakeStep(Game.Direction.RIGHT);
            game.Render();
            Thread.Sleep(250);
            game.player.TakeStep(Game.Direction.RIGHT);
            game.Render();
            Thread.Sleep(250);
            game.player.TakeStep(Game.Direction.RIGHT);
            game.Render();
            Thread.Sleep(250);
            game.player.TakeStep(Game.Direction.DOWN);
            game.Render();
            Thread.Sleep(250);
            game.player.TakeStep(Game.Direction.DOWN);
            game.Render();
            Thread.Sleep(250);
            game.player.TakeStep(Game.Direction.DOWN);
            game.Render();
            Thread.Sleep(250);
            game.player.TakeStep(Game.Direction.DOWN);
            game.Render();
            
        }
    }
}
