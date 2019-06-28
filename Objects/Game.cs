using System;
using snake.Objects;
using System.Collections.Generic;
using System.Linq;

namespace snake.Objects
{
    public class Game
    {
        public string[,] matrix = new string[10, 20];
        private Snake player = new Snake();

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
            for (int row = 0; row < 10; row++)
            {
                string line = "";
                for (int col = 0; col < 20; col++)
                {
                    /*  vv ADDS SNAKE TO BOARD vv*/
                    if (player.Locations.Contains(new int[2] {row, col}))
                    {
                        // PIECE OF SNAKE
                        pieceOfSnake++;
                        if (player.Locations[0][0] == row && player.Locations[0][1] == col)
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
                        line += matrix[row, col];
                    }
                    /* ^^ ADDS SNAKE TO BOARD ^^ */
                    
                }
                Console.WriteLine( $"|{line}|" );
            }
            Console.WriteLine(end);
            Console.WriteLine($"{pieceOfSnake} pieces of snake");
        }

        public void TakeStep(Direction d)
        {

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