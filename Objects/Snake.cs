using System;
using System.Collections.Generic;
namespace snake.Objects
{
    public class Snake
    {
        public readonly string Dead = "X";
        public readonly string Head = "Q";
        public readonly string Body = "O";

        public readonly int[] DOWN = new int[2] { 0, 1 };
        public readonly int[] UP = new int[2] { 0, -1 };
        public readonly int[] RIGHT = new int[2] { 1, 0 };
        public readonly int[] LEFT = new int[2] { -1, 0 };

        public int Length = 4;
        public int[] Location = new int[2];
        public Game.Direction Facing = new Game.Direction();

        public Snake()
        {
            Facing = Game.Direction.UP;
            Location[0] = 10;
            Location[1] = 3;
        }
        
        public void SetDirection(Game.Direction direction)
        {
            Facing = direction;
        }

    }
}