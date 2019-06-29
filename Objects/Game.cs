using System;
using snake.Objects;
using System.Collections.Generic;
using System.Linq;

namespace snake.Objects
{
    public class Game
    {
        public string[,] matrix = new string[10, 20];
        public Snake player = new Snake();

        public Game()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matrix[i, j] = " ";
                }
            }
            player = new Snake();
        }

        public void Render()
        {
            int pieceOfSnake = 0;
            
            string end = "+";
            for (int col = 0; col < 20; col++) {end+="-";}
            end += "+";
            Console.WriteLine(end);
            for (int y = 0; y < 10; y++)
            {
                string line = "";
                for (int x = 0; x < 20; x++)
                {
                    /*  vv ADDS SNAKE TO BOARD vv*/
                    if (IsSnakeHere(new int[2] {x, y}))
                    {
                        // PIECE OF SNAKE
                        pieceOfSnake++;
                        if (player.GetHead()[0] == x && player.GetHead()[1] == y)
                        {
                            line += player.head;
                        }
                        else
                        {
                            line += player.body;
                        }
                        
                    }
                    else
                    {
                        line += matrix[y, x];
                    }
                    /* ^^ ADDS SNAKE TO BOARD ^^ */
                    
                }
                Console.WriteLine( $"|{line}|" );
            }
            Console.WriteLine(end);
            Console.WriteLine($"{pieceOfSnake} pieces of snake");
        }

        public enum Direction
        {
            UP = 0,
            RIGHT,
            DOWN,
            LEFT
        }

        public Boolean IsSnakeHere(int[] location)
        {
            foreach (int[] snake in player.Locations)
            {
                if (snake[0] == location[0] && snake[1] == location[1])
                {
                    return true;
                }
            }
            return false;
        }

    }
}