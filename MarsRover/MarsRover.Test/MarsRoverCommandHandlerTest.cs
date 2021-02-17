using NUnit.Framework;

namespace MarsRover.Test
{
    [TestFixture]
    public class MarsRoverCommandHandlerTest
    {
        [TestCase("5 5\n1 2 N\nLMLMLMLMM\n3 3 E\nMMRMMRMRRM", "1 3 N\r\n5 1 E\r\n")]
        public void example_scenario_test(string command, string expectedResults)
        {

            var roveRepo = new MarsRoveRepo();
            var gridRepo = new GridRepo();
            var handler = new MarsRoverCommandHandler(roveRepo, gridRepo);
            var results = handler.HandleCommand(command);

            Assert.That(results, Is.EqualTo(expectedResults));
        }

    }
}
