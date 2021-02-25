using Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Enities
{
    public class Cell
    {
        public Position Position { get; protected set; }
        public CellState State { get; protected set; }

        public Cell()
        {
            Position = new Position();
            State = CellState.Unknown;
        }

        public Cell(CellState state, int x = 0, int y = 0) : this(state, new Position(x, y))
        {
            Position = new Position();
            State = CellState.Unknown;
        }

        public Cell(CellState state, Position position)
        {
            Position = position;
            State = state;
        }
    }
}
