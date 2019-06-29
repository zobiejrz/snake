using System;
using System.Collections.Generic;
namespace snake.Objects
{
    public class Snake
    {
        public string Dead = "X";
        public string Head = "Q";
        public string Body = "O";

        public readonly int[] Down = new int[2] { 0, 1 };
        public readonly int[] Up = new int[2] { 0, -1 };
        public readonly int[] Right = new int[2] { 1, 0 };
        public readonly int[] Left = new int[2] { -1, 0 };

        public int Length = 4;
        public readonly int[] Location = new int[2];
        public Game.Direction Facing = new Game.Direction();

        public Snake()
        {
            Facing = Game.Direction.Up;
            Location[0] = 10;
            Location[1] = 3;
        }
        
        public void SetDirection(Game.Direction direction)
        {
            Facing = direction;
        }

    }
}