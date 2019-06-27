using System;
using System.Collections.Generic;
using System.Text;
namespace snake.Objects
{
    public class Square
    {
        public string State = "";
        public int[] Location = new int[2];
        public Square(int x, int y, string State)
        {
            this.State = State;
            this.Location[0] = x;
            this.Location[1] = y;
        }
    }
}