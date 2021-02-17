using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public interface IGridRepo
    {
        public IMarsRoverGrid GetGrid(int width, int hight);
    }
}
