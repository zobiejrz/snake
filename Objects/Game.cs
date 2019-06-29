using System;
using snake.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace snake.Objects
{
    public class Game
    {
        public Square[,] matrix = new Square[10, 20];
        public Snake player = new Snake();

        public Game()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matrix[i, j] = new Square(i, j);
                }
            }
            player = new Snake();
            matrix[3, 10].state = player.Head;
            matrix[3, 10].decay = player.Length;
        }

        public void Render()
        {
            foreach (Square square in matrix)
            {
                if (square.decay > 0)
                {
                    square.state = player.Body;
                }
                else
                {
                    square.state = " ";
                }
            }
            int sy = player.Location[0];
            int sx = player.Location[1];
            matrix[sx, sy].state = player.Head;
            matrix[sx, sy].decay = player.Length;

            string end = "+";
            for (int col = 0; col < 20; col++) {end+="-";}
            end += "+";
            Console.WriteLine(end);

            int currentX = 0;
            foreach (Square square in matrix)
            {
                if (currentX == 0)
                {
                    Console.Write("|");
                }
                
                Console.Write(square.state);
                currentX++;
                if (currentX == 20)
                {
                    Console.Write("|\n");
                    currentX = 0;
                }

                if (square.decay != 0)
                {
                    square.decay--;
                }
            }
            
            Console.WriteLine(end);
        }
        
        public void TakeStep(Game.Direction d)
        {
            int[] direction = new int[2];
            switch (d)
            {
                case Game.Direction.UP:
                    direction = player.UP;
                    break;
                case Game.Direction.RIGHT:
                    direction = player.RIGHT;
                    break;
                case Game.Direction.DOWN:
                    direction = player.DOWN;
                    break;
                case Game.Direction.LEFT:
                    direction = player.LEFT;
                    break;
            }

            player.Location[0] += direction[0];
            player.Location[1] += direction[1];
            
            this.Render();
            Thread.Sleep(250);
        }

        public void Feed()
        {
            player.Length++;
            foreach (Square square in matrix)
            {
                if (square.decay > 0)
                {
                    square.decay++;
                }
            }
        }
        

        public enum Direction
        {
            UP = 0,
            RIGHT,
            DOWN,
            LEFT
        }

    }
}