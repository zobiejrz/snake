using System;
using snake.Objects;
using System.Collections.Generic;
namespace snake.Objects
{
    public class Game
    {
        private int w = 10;
        private int h = 10;
        private List<Square> matrix = new List<Square>();

        public Game(int w, int h)
        {
            this.w = w;
            this.h = h;
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    Square tempSquare = new Square(x, y, " ");
                    matrix.Add(tempSquare);
                }
            }
        }

        public void Render()
        {
            string end = "+";
            for (int i = 0; i < w; i++) {end+="-";}
            end += "+";
            
            Console.WriteLine( $"Matrix is {matrix.Count}" );
            Console.WriteLine(end);

            int count = 0;
            for (int i = 0; i < h; i++)
            {
                string row = "";
                for (int j = 0; j < w; j++)
                {
                    row += matrix[count].State;
                    count++;
                }
                Console.WriteLine( $"|{row}|" );
            }

            Console.WriteLine(end);
        }
    }
}