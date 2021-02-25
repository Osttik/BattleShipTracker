using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Enities
{
    public class Ship
    {
        public int NumberOfCells { get; protected set; }

        private readonly List<Cell> _cells;

        public Cell this[int cellId]
        {
            get => _cells[cellId];
            set => _cells[cellId] = value;
        }

        public Ship(params Cell[] cells)
        {
            _cells = new List<Cell>(cells);
            NumberOfCells = _cells.Count;
        }
    }
}
