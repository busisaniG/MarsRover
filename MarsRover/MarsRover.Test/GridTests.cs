using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover.Test
{
    [TestFixture]
    public class GridTests
    {
        [Test]
        public void Init_give_5_by_5_grid_return_grid_with_5_by_5_cels()
        {
            var grid = new MarsRoverGrid(5,5);
            Assert.That(grid.Grid.Length, Is.EqualTo(25));
            Assert.That(grid.Grid[4,4], Is.Not.Null);
        }

        [Test]
        public void LandRover_give_landing_at_1_3_N_suold_mark_landing_celas_occupied()
        {
            var grid = new MarsRoverGrid(5, 5);
            grid.LandRove(1, 3);
            Assert.That(grid.Grid[1, 3].Occupied, Is.True);
        }
    }
}
