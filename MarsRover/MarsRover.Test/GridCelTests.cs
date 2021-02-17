using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Test
{
    [TestFixture]
    public class GridCelTests
    {

        [Test]
        public void CanJumpIn_given_cel_is_occupied_by_rover_return_false()
        {
            var cel = new GridCel(true);
            var results = cel.CanJumpIn();
            Assert.That(results, Is.False);
        }

        [Test]
        public void CanJumpIn_given_cel_is_not_occupied_by_rover_return_true()
        {
            var cel = new GridCel(false);
            var results = cel.CanJumpIn();
            Assert.That(results, Is.True);
        }
    }
}
