using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class MarsRover : IMarsRover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Direction { get; set; }
        private IMarsRoverGrid Grid;

        public MarsRover(int x, int y, char direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public void Land(IMarsRoverGrid grid)
        {
            Grid = grid;
            Grid.Grid[X, Y].Occupied = true;
        }

        public string Rove(string input)
        {
            string position = string.Empty;
            foreach (char command in input)
            {
                position = Rove(command);
            }
            return position;
        }
        public string Rove(char input)
        {
            if (input == 'L')
                TurnLeft();
            else if (input == 'R')
                TurnRight();
            else if (input == 'M')
                Move();
            return X + " " + Y + " " + Direction;
        }

        public void Move()
        {
            Grid.Grid[X, Y].Occupied = false;
            if (Direction == 'N')
                Y++;
            else if (Direction == 'W')
                X--;
            else if (Direction == 'S')
                Y--;
            else if (Direction == 'E')
                X++;
            Grid.Grid[X, Y].Occupied = true;
        }

        public void TurnLeft()
        {
            if (Direction == 'N')
                Direction = 'W';
            else if (Direction == 'W')
                Direction = 'S';
            else if (Direction == 'S')
                Direction = 'E';
            else if (Direction == 'E')
                Direction = 'N';
        }
        public void TurnRight()
        {
            if (Direction == 'N')
                Direction = 'E';
            else if (Direction == 'W')
                Direction = 'N';
            else if (Direction == 'S')
                Direction = 'W';
            else if (Direction == 'E')
                Direction = 'S';
        }


    }

}
