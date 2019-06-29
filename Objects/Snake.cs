using System;
using System.Collections.Generic;
namespace snake.Objects
{
    public class Snake
    {
        public readonly string dead = "X";
        public readonly string head = "Q";
        public readonly string body = "O";

        public readonly int[] DOWN = new int[2] { 0, 1 };
        public readonly int[] UP = new int[2] { 0, -1 };
        public readonly int[] RIGHT = new int[2] { 1, 0 };
        public readonly int[] LEFT = new int[2] { -1, 0 };

        public List<int[]> Locations = new List<int[]>();
        
        public Game.Direction Facing = new Game.Direction();
        
        public Snake()
        {
            Facing = Game.Direction.UP;
            // Starts with 3 body segments + Head
            for (int i = 0; i < 4; i++)
            {
                int[] location = new int[2];
                location[0] = 10;
                location[1] = 5 - i;
                Locations.Add(location);
            }
        }

        public void SetDirection(Game.Direction direction)
        {
            Facing = direction;
        }

        public int[] GetHead()
        {
            return Locations[0];
        }

        public void TakeStep(Game.Direction d)
        {
            int[] direction = new int[2];
            switch (d)
            {
                case Game.Direction.UP:
                    direction = UP;
                    break;
                case Game.Direction.RIGHT:
                    direction = RIGHT;
                    break;
                case Game.Direction.DOWN:
                    direction = DOWN;
                    break;
                case Game.Direction.LEFT:
                    direction = LEFT;
                    break;
            }


            foreach (int[] segment in Locations)
            {
                segment[0] += direction[0];
                segment[1] += direction[1];
            }
            


        }

    }
}