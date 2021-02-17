using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var roveRepo = new MarsRoveRepo();
            var gridRepo = new GridRepo();
            var handler = new MarsRoverCommandHandler(roveRepo, gridRepo);
            var results = handler.HandleCommand(args[0]);
        }
    }
}
