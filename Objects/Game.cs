using System;
using System.Threading;

namespace snake.Objects
{
    public class Game
    {
        private Square[,] matrix = new Square[10, 20];
        private readonly Snake _player;
        public bool IsNotDead = true;
        public int Score = 0;

        public Game()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matrix[i, j] = new Square(i, j);
                }
            }
            _player = new Snake();
            int sy = _player.Location[0];
            int sx = _player.Location[1];
            matrix[sx, sy].state = _player.Head;
            matrix[sx, sy].decay = _player.Length - 1;
        }

        public void Render()
        {

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
        
        public void TakeStep(Direction d)
        {
            _player.Facing = d;
            int[] direction = new int[2];
            switch (d)
            {
                case Direction.Up:
                    direction = _player.Up;
                    break;
                case Direction.Right:
                    direction = _player.Right;
                    break;
                case Direction.Down:
                    direction = _player.Down;
                    break;
                case Direction.Left:
                    direction = _player.Left;
                    break;
            }

            if (_player.Location[0] + direction[0] < 20)
            {
                if (_player.Location[0] + direction[0] >= 0)
                {
                    _player.Location[0] += direction[0];
                }
                else
                {
                    if (_player.Facing == Direction.Right)
                    {
                        _player.Location[0] = 0;
                    }
                    else if (_player.Facing == Direction.Left)
                    {
                        _player.Location[0] = 19;
                    }
                    
                }
            }
            else
            {

                _player.Location[0] = 0;
            }

            if (_player.Location[1] + direction[1] < 10)
            {
                
                if (_player.Location[1] + direction[1] >= 0)
                {
                    _player.Location[1] += direction[1];
                }
                else
                {
                    if (_player.Facing == Direction.Down)
                    {
                        _player.Location[1] = 0;
                    }
                    else if (_player.Facing == Direction.Up)
                    {
                        _player.Location[1] = 9;
                    }
                    
                }
            }
            else
            {

                _player.Location[1] = 0;
            }
            
            foreach (Square square in matrix)
            {
                square.state = square.decay > 0 ? _player.Body : " ";
            }
            
            int sy = _player.Location[0];
            int sx = _player.Location[1];
            if (matrix[sx, sy].state == "O")
            {
                IsNotDead = false;
                matrix[sx, sy].state = _player.Dead;
            }
            else
            {
                matrix[sx, sy].state = _player.Head;

            }
            matrix[sx, sy].decay = _player.Length;

            Render();
                
//            Thread.Sleep(250);
        }

        public void Feed()
        {
            _player.Length++;
            foreach (Square square in matrix)
            {
                if (square.decay > 0)
                {
                    square.decay++;
                }

                Score++;
            }
        }
        

        public enum Direction
        {
            Up = 0,
            Right,
            Down,
            Left
        }

    }
}