using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class MarsRoverCommandHandler
    {
        private IMarsRoveRepo marsRoveRepo;
        private IGridRepo gridRepo;

        public MarsRoverCommandHandler(IMarsRoveRepo marsRoveRepo, IGridRepo gridRepo)
        {
            this.marsRoveRepo = marsRoveRepo;
            this.gridRepo = gridRepo;
        }

        public string HandleCommand(string command)
        {
            var commandArg = command.Split("\n");
            var griddimentions = commandArg[0].Split();

            var grid = gridRepo.GetGrid(Int16.Parse(griddimentions[0]), Int16.Parse(griddimentions[0]));
            var index = 1;
            StringBuilder results = new StringBuilder();
            while (index < commandArg.Length)
            {
                var initialPosition = commandArg[index].Split();
                var rover = marsRoveRepo.GetMarsRover(Int16.Parse(initialPosition[0]), Int16.Parse(initialPosition[1]), Char.Parse(initialPosition[2]));
                rover.Land(grid);

                results.AppendLine(rover.Rove(commandArg[index + 1]));
                index += 2;
            }

            return results.ToString();
        }
    }
}
