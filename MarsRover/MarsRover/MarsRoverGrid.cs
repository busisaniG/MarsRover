using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class MarsRoverGrid : IMarsRoverGrid
    {
        public GridCel[,] Grid { get; protected set; }
        public MarsRoverGrid(int width, int hight)
        {
            Grid = new GridCel[width, hight];

            for (var i = 0; i < width; i++)
            {
                for (var z = 0; z < hight; z++)
                {
                    Grid[i, z] = new GridCel();
                }
            }
        }

        public void LandRove(int x, int y)
        {
            Grid[x, y].Occupied = true;
        }
    }
}
