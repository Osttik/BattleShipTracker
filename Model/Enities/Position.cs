using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Enities
{
    public class Position
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }

        public Position()
        {
            X = 0;
            Y = 0;
        }
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
