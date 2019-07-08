namespace snake.Objects
{
    public class Square
    {
        public int[] location = new int[2];
        public int decay = 0;
        public string state = " ";

        public Square(int x, int y)
        {
            location = new int[2] {x, y};
        }
    }
}