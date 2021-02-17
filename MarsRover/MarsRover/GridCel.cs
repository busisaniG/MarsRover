using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class GridCel
    {
        public  bool Occupied { get; set; }
        public GridCel(bool occupied = false)
        {
            Occupied = occupied;
        }

        public object CanJumpIn()
        {
            return !Occupied;
        }
    }
}
