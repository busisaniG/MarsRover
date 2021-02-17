using NUnit.Framework;

namespace MarsRover.Test
{
    [TestFixture]
    public class GridMarsRoverTest
    {
        [Test]
        public void init_give_landing_at_1_3_N_shuold_mark_landing_cel_as_occupied()
        {
            var grid = new MarsRoverGrid(5, 5);
            var rover = new MarsRover(1, 2, 'N');
            rover.Land(grid);

            Assert.That(grid.Grid[1, 2].Occupied, Is.True);
        }

        [Test]
        [TestCase('N','L', "1 2 W")]
        [TestCase('N','R', "1 2 E")]
        [TestCase('W','L', "1 2 S")]
        [TestCase('W','R', "1 2 N")]
        [TestCase('E','L', "1 2 N")]
        [TestCase('E','R', "1 2 S")]
        [TestCase('S','L', "1 2 E")]
        [TestCase('S','R', "1 2 W")]
        public void given_a_rover_at_1_2_with_initialDirection_recieves_command_return_results_grid_not_updated(char initialDirection, char command, string results)
        {
            var grid = new MarsRoverGrid(5, 5);
            var rover = new MarsRover(1, 2, initialDirection);
            rover.Land(grid);
            var reslts = rover.Rove(command);

            Assert.That(reslts, Is.EqualTo(results));
            Assert.That(grid.Grid[1, 2].Occupied, Is.True);
        }

        [TestCase('N', 'M', "1 3 N")]
        [TestCase('E', 'M', "2 2 E")]
        [TestCase('S', 'M', "1 1 S")]
        [TestCase('W', 'M', "0 2 W")]
        public void given_a_rover_at_1_2_with_initialDirection_recieves_command_return_results_update_grid(char initialDirection, char command, string results)
        {
            var grid = new MarsRoverGrid(6, 6);
            var rover = new MarsRover(1, 2, initialDirection);
            rover.Land(grid);
            var reslts = rover.Rove(command);

            Assert.That(reslts, Is.EqualTo(results));
            Assert.That(grid.Grid[1, 2].Occupied, Is.False);
            Assert.That(grid.Grid[rover.X, rover.Y].Occupied, Is.True);
        }
        
        [TestCase(1, 2, 'N', "LMLMLMLMM", "1 3 N")]
        [TestCase(3, 3, 'E', "MMRMMRMRRM", "5 1 E")]
        public void Rove_given_a_rover_at_initial_position_recieves_command_return_results_update_grid(int initilX, int initialY, char initialDirection, string command, string results)
        {
            var grid = new MarsRoverGrid(6, 6);
            var rover = new MarsRover(initilX, initialY, initialDirection);
            rover.Land(grid);
            var reslts = rover.Rove(command);
            Assert.That(reslts, Is.EqualTo(results));

            Assert.That(grid.Grid[initilX, initialY].Occupied, Is.False);
            Assert.That(grid.Grid[rover.X, rover.Y].Occupied, Is.True);
        }
    }
}
