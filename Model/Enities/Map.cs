using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Enities
{
    public class Map
    {
        public int Height { get; protected set; }
        public int Width { get; protected set; }

        private List<List<Cell>> _cells;

        public Cell this[int h, int w]
        {
            get => _cells[h][w];
            set => _cells[h][w] = value;
        }

        public Map(int height = 10, int width = 10)
        {
            Height = height;
            Width = width;

            InitializeMap();
        }

        protected void InitializeMap()
        {
            _cells = new List<List<Cell>>();
            for (int i = 0; i < Height; i++)
            {
                List<Cell> newRow = new List<Cell>();

                for (int j = 0; j < Width; j++)
                {
                    newRow.Add(new Cell(Enums.CellState.Free));
                }

                _cells.Add(newRow);
            }
        }
    }
}
