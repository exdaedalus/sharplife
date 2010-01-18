using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpLife.Lib
{
    public class Board
    {
        private int[,] _board = null;

        public Board(int height, int width)
        {
            _board = new int[height, width];
        }

        public int Height
        {
            get { return _board.GetLength(0); }
        }

        public int Width
        {
            get { return _board.GetLength(1); }
        }

        public bool this[int x, int y]
        {
            get { return (_board[x, y] == 1); }
            set { _board[x, y] = (value) ? 1 : 0; }
        }

        public void Init(int x, int y, int[,] boardInit)
        {
            for(int i = 0; i < Math.Min(Height, boardInit.GetLength(0)); ++i)
            {
                for(int j = 0; j < Math.Min(Width, boardInit.GetLength(1)); ++j)
                {
                    _board[x + i, y + j] = boardInit[i, j];
                }
            }
        }

        public void Print()
        {
            for(int i = 0; i < Height; ++i)
            {
                for(int j = 0; j < Width; ++j)
                {
                    Console.Write(_board[i,j].ToString());
                }
                Console.WriteLine();
            }
        }
    }
}
