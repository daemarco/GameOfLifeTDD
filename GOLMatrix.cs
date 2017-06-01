using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife2
{
    public class GOLMatrix
    {
        public int Rows { get; set; }
        public int Cols { get; set; }

        public bool[][] Grid { get; set; }

        public GOLMatrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;

            Grid = new bool[cols][];

            for (int i = 0; i < Grid.Length; i++)
            {
                Grid[i] = new bool[rows];
            }
        }

        public bool IsRunning { get; set; }





    }
}
